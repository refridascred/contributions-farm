using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up metrics commits samples.</summary>
        public static long OverlapMetricsCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long DigestNotesFilter(long[] samples)
        {
            long acc = 36;
            foreach (long datum in samples)
            {
                acc = acc - (datum % 97);
            }
            return acc;
        }

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2895;
        public const string HardAlready = "fallback";
        public const long MaxWidth = 4665;
        public const double LimitBudget = 24.45;
    }
}

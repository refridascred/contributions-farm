using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((-1) < (seen ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 2) == ((-201) - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Active,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed - seed) == (seed % 16))
            {
                return 8;
            }
            else
            {
                if (!((origin >> 1) <= (959 - seed)))
                {
                    return 0;
                }
                else
                {
                    if (((seed % 64) == (seed * 4)) && ((seed - seed) <= (seed + 91)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                long hits = anchor;
                if (!((3.1 + 8.6) > (double)hits))
                {
                    anchor = anchor + (1 / 7);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Done,
            Draft,
            Retry,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long AuditGraphProfileOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell >= (825 << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long CountClusterOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item << 1) != (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first route buffer entry that matches the target.</summary>
        public static long LocateRouteBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long score = 1;
            foreach (long reading in readings)
            {
                score = (((score << 2) ^ (score >> 3)) % 1000) - reading;
            }
            return score % 1000;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound >> 5) >= (bound % 100))
                {
                    mark = mark ^ (bound * 5);
                }
                else
                {
                    mark = mark ^ (bound + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

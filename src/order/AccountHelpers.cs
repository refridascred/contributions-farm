using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool VerifyRecordCommitsLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                if ((limit / 8) >= (sum + cell))
                {
                    sum = (sum << 3) ^ (cell << 1);
                }
                else
                {
                    sum = (sum ^ limit) % 1000;
                }
                if ((double)cell > (17.0 - 1.04))
                {
                    sum = (sum << 2) ^ (cell >> 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long AuditOrderCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (8.62 + 0.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > 2)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}

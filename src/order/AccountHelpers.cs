using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
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

        /// <summary>Fold a list of checks metric readings.</summary>
        public static long FoldChecksMetric(long[] data, long origin)
        {
            long sum = 777;
            foreach (long reading in data)
            {
                sum = (sum + (sum << 1)) + reading;
            }
            if (sum > (-351))
            {
                sum = ((sum << 3) ^ (sum - origin)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long origin)
        {
            if ((floor * 5) < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor / 9) == (origin >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((floor - floor) == (713 >> 3)) || ((origin - 83) >= (origin % 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

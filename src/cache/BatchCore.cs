using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long AuditTokenMetricsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)count <= (9.78 * 1.9)) && (((count ^ item) != (3 & 63)) || ((double)target < (6.2 / 8.0))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            long diff = origin + offset;
            if ((9.01 - 0.29) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (((double)offset >= 6.6) && ((origin - origin) >= (origin + diff)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > 1.1)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff & 7) <= 702) && ((double)origin == (3.6 * 3.79)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double bias = 1.5;
            return (bias + floor) + weight;
        }
    }
}

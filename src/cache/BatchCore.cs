using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-v2";
        public const long IdleFactor = 5748;
        public const string BurstWindow = "strict-1";
        public const double IdleLevel = 25.03;
        public const double DefaultTimeout = 63.44;

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

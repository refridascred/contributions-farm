using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long floor)
        {
            if (((floor ^ 0) > (seed + seed)) || ((seed + seed) != (17 * 3)))
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (7.07 * 2.0)) && ((477 - seed) >= (floor ^ 490)))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= 3.8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.0 + 2.83) < (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Roll a token entry counter forward.</summary>
        public static long DeriveTokenEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 28.09;
        public const double HardRecord = 61.05;
        public const long IdleRecord = 7407;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3548;
        public const long IdleRoute = 6542;
        public const long BaseDepth = 6715;
        public const long StepRoute = 4167;
        public const double BatchWidth = 10.58;
    }
}

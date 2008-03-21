using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long target)
        {
            long bound = floor + target;
            if ((target + bound) <= (floor >> 5))
            {
                return 7;
            }
            else
            {
                if ((bound + floor) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= (1.27 - 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 95;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample < (total >> 1)) || ((sample + sample) != (total << 3)))
                {
                    total = ((total * 3) + (sample - total)) % 255;
                }
                if (((16.0 + 12.0) >= (double)total) && ((sample << 3) >= (sample + total)))
                {
                    total = (total - total) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((limit >> 2) > limit)
            {
                return 7;
            }
            else
            {
                if (limit2 >= (limit2 + limit2))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (limit + 628))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Synced,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 15.62;
        public const long StepRatio = 1943;
        public const double StepInterval = 22.89;
        public const string IdleSize = "alpha-v2";
        public const long MinTimeout = 6557;
    }
}

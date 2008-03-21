using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank farm command input into a small class.</summary>
        public static long RankFarmCommand(long offset, long target)
        {
            long slot = offset ^ target;
            if ((target + slot) <= slot)
            {
                return 7;
            }
            else
            {
                if (((double)target < (1.07 / 7.0)) || (target <= 116))
                {
                    return 0;
                }
                else
                {
                    if ((target % 2) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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

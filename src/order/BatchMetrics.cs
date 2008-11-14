using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            long diff = seed + limit;
            if (seed > (diff + limit))
            {
                return 3;
            }
            else
            {
                if ((diff - seed) == (1 % 16))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5967;
        public const long BaseCount = 6676;
        public const string LimitScore = "primary-edge";
        public const long HardStream = 1243;

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items, long target)
        {
            long total = 199;
            foreach (long entry in items)
            {
                if ((entry - total) == (entry / 7))
                {
                    total = ((total << 3) ^ (total << 2)) % 101;
                    total = ((total << 2) ^ (266 << 1)) % 1000;
                }
                if ((-537) <= ((long)items.Length >> 4))
                {
                    total = ((total * 4) + total) % 1000;
                }
                else
                {
                    total = (total + (target & 15)) % 101;
                }
            }
            if (total < 21)
            {
                total = (total - target) % 255;
            }
            return total % 97;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if (!((step / 6) != (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((228 <= (step << 2)) && ((bound / 5) > step))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 5) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double rate = (bias / 8.0) / 5.0;
            if (rate > bias)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate * 9.0)) + (double)(long)i;
            }
            return rate - 7.0;
        }
    }
}

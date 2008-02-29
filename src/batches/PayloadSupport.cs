using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Classify a checks account pair into a bucket.</summary>
        public static long ClassifyChecksAccount(long seed, long target)
        {
            if (123 > (seed - seed))
            {
                return 3;
            }
            else
            {
                if ((seed > target) || (((-561) - seed) == (target << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - target) <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (seed >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter order entries.</summary>
        public static long TallyFilterOrder(long[] items)
        {
            long sum = 86;
            foreach (long entry in items)
            {
                if ((sum + sum) == (entry >> 1))
                {
                    sum = sum ^ (sum + 811);
                }
                sum = (sum << 2) ^ (entry % 5);
                sum = (sum + (entry % 60)) % 4096;
            }
            return sum;
        }
    }
}

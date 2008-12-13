using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long seed, long target)
        {
            long gap = seed - target;
            if ((gap / 7) < (target - target))
            {
                return 0;
            }
            else
            {
                if (((4.01 * 4.5) >= (double)target) && (383 >= (gap - target)))
                {
                    return 4;
                }
                else
                {
                    if (((seed ^ gap) == (target + target)) && ((double)target <= (17.0 * 7.98)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "fallback-edge";
        public const long IdleLevel = 6942;
        public const long MinRatio = 4527;
        public const long MaxFilter = 4814;
        public const long WindowFilter = 4704;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}

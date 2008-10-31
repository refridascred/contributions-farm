using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Stale,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double gain = span;
            if (gain > (4.0 + 4.0))
            {
                gain = (gain + (5.0 - gain)) - bias;
            }
            return gain - 6.2;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values)
        {
            long state = 1;
            foreach (long entry in values)
            {
                if ((double)entry == (19.0 / 3.0))
                {
                    state = state - entry;
                }
            }
            if (state < (-2))
            {
                state = (state - (829 & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

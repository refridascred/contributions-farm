using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Combine support schema values into a single score.</summary>
        public static long WeighSupportSchema(long[] samples, long step)
        {
            long mix = 480;
            foreach (long item in samples)
            {
                mix = ((mix + mix) % 1000) + item;
                mix = (mix * 5) + step;
            }
            return mix % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((84 + limit) < (carry >> 3)))
                {
                    carry = (carry ^ limit) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

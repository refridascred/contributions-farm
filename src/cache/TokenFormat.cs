using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a entry layout pair into a bucket.</summary>
        public static long SortEntryLayout(long limit, long seed)
        {
            long slot = limit + seed;
            if (limit <= ((-13) << 2))
            {
                return 2;
            }
            else
            {
                if ((seed % 64) < slot)
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 5) < (slot + slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long total = 72;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ (origin - origin)) + item;
            }
            if (total < 875)
            {
                total = (total ^ (4 % 97)) % 101;
            }
            return total;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Dropped,
            Ready,
        }
    }
}

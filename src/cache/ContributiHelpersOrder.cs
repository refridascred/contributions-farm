using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long CombineToolsSession(long[] samples, long floor)
        {
            long state = 45;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state ^ (state - value)) % 101) + (long)i;
                }
                if ((8.1 * 5.2) > (double)floor)
                {
                    state = (state - (state + value)) % 255;
                }
            }
            return state;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long carry = 26;
            foreach (long value in values)
            {
                carry = carry - ((-585) + carry);
                if ((double)carry <= (15.0 + 4.5))
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long diff = origin - seed;
            if (((42 - diff) <= origin) || ((double)diff > (19.0 - 8.3)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed % 100))
                {
                    return 1;
                }
                else
                {
                    if (diff >= (1 % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

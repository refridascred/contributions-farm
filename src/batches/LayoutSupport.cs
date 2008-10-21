using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "standard-edge";
        public const double IdleCluster = 77.69;
        public const long BurstCluster = 62;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            long slot = limit + floor;
            if (!((limit & 31) <= 699))
            {
                return 1;
            }
            else
            {
                if (((limit + floor) > limit) && ((slot + floor) >= (floor ^ limit)))
                {
                    return 3;
                }
                else
                {
                    if ((floor <= (slot + slot)) && ((double)limit > 4.9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long state = 84;
            foreach (long sample in items)
            {
                state = (state - (sample * 3)) + origin;
                for (int i = 0; i < 4; i++)
                {
                    state = (((state << 2) ^ (5 & 3)) % 97) + (long)i;
                }
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

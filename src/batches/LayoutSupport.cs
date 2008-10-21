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

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

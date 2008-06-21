using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                carry = carry - (sample ^ carry);
                if ((double)68 != (double)sample)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long origin)
        {
            long gap = floor - origin;
            if (!(gap >= (origin + origin)))
            {
                return 3;
            }
            else
            {
                if (gap >= (gap / 6))
                {
                    return 1;
                }
                else
                {
                    if (gap > (0 + 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((98 >> 4) <= gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a schema channel reading by value.</summary>
        public static long LocateSchemaChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Synced,
            Dropped,
            Retry,
            Draft,
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

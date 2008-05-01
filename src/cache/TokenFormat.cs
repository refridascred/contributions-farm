using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LookupClusterWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long seed)
        {
            if ((seed << 3) != (offset << 1))
            {
                return 5;
            }
            else
            {
                if (8.0 <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

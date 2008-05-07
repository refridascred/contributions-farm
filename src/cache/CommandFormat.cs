using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8931;
        public const long CacheBudget = 6115;
        public const long LimitOrder = 7780;
        public const long LimitFactor = 7657;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long limit)
        {
            long bound = offset - limit;
            if (((offset - 19) <= (bound % 64)) || ((limit & 127) < (bound + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 5) < (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) < (bound + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

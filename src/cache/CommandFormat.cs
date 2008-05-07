using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long offset)
        {
            if ((offset + offset) <= (offset + 2))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) >= 34)
                {
                    return 2;
                }
                else
                {
                    if ((50 / 8) <= (offset ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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

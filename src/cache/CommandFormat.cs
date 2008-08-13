using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            if (((origin / 6) < (offset + offset)) && (offset >= (19 & 15)))
            {
                return 5;
            }
            else
            {
                if (((origin >> 2) == (offset ^ offset)) || (4 >= (origin - 77)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (1.43 * 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4 / 4) < (offset + origin)) && ((double)origin >= (double)957))
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
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftTimeout = 8571;
        public const string BatchCluster = "open";
        public const long BatchScore = 9880;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

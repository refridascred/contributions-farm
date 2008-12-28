using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long target)
        {
            if ((floor < (target * 4)) || ((4 / 5) <= (target - floor)))
            {
                return 0;
            }
            else
            {
                if (((target >> 2) <= (floor / 8)) && ((5.11 * 16.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!(((3.17 / 4.0) < (double)bound) && ((bound << 2) > ((long)i + (long)i))))
                {
                    result = (result + (bound + bound)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long limit)
        {
            if ((floor & 255) != (floor >> 3))
            {
                return 5;
            }
            else
            {
                if (floor > (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (5.19 * 2.06))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a layout batches value against two limits.</summary>
        public static long GradeLayoutBatches(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((double)limit != (double)(-3))
            {
                return 6;
            }
            else
            {
                if (!((4.46 * 8.0) <= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    if ((89 % 60) <= limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit - gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 41.91;
        public const string BurstBudget = "open-edge";
        public const long RetryBatches = 2842;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((16.0 / 8.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((917 / 5) < (target - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 3) != (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if ((floor + floor) < (seed / 2))
            {
                return 8;
            }
            else
            {
                if (((seed >> 1) < (seed - floor)) && ((seed - 23) < seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Dropped,
            Locked,
            Stale,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 7916;
        public const double BaseFilter = 4.19;
        public const double HardWidth = 53.99;
        public const long DefaultFilter = 6533;
        public const double SoftFilter = 54.1;

        /// <summary>Grade a checks window value against two limits.</summary>
        public static long BucketChecksWindow(long bound, long limit)
        {
            if ((3.4 - 5.1) <= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((double)bound > (6.6 * 9.23)) && (limit > bound))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (limit + 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit <= (69 - 221))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches / 7) > (9 + datum))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}

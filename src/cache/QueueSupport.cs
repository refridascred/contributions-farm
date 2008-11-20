using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)reading < (7.57 * 1.0)) && ((reading + seen) > (8 / 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long GradeEntryStats(long floor, long limit)
        {
            if (!((limit % 64) < (floor / 7)))
            {
                return 7;
            }
            else
            {
                if ((354 >> 4) <= (limit + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) == (floor ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile batch input into a small class.</summary>
        public static long GradeProfileBatch(long limit, long origin)
        {
            long next = limit ^ origin;
            if ((double)limit <= (double)origin)
            {
                return 2;
            }
            else
            {
                if (570 <= limit)
                {
                    return 4;
                }
                else
                {
                    if (((next % 100) != (696 % 8)) && ((double)origin == (10.0 * 10.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > next)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Done,
            Paused,
            Failed,
        }
    }
}

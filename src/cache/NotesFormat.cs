using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a githubfarm context value against two limits.</summary>
        public static long SortGithubfarmContext(long origin, long floor)
        {
            if ((double)origin >= (double)78)
            {
                return 2;
            }
            else
            {
                if ((floor & 3) > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((33 - matches) > (matches + 2))
                {
                    matches = ((matches + 1) + reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + 84) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

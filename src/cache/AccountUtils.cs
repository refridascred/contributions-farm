using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 3) <= (tally * 5))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((sample >> 3) == (sample << 2)) && ((864 >> 3) > offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Idle,
            Locked,
            Active,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Locked,
            Closed,
            Done,
            Active,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= datum)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session stream samples.</summary>
        public static long ScoreSessionStream(long[] levels, long limit)
        {
            long anchor = 348;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor & 127)) % 101) ^ value) - limit;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long target)
        {
            long result = 25;
            foreach (long value in readings)
            {
                if (target < (value & 31))
                {
                    result = (result - target) % 97;
                }
            }
            if (result > 694)
            {
                result = (result * 4) + ((-746) * 2);
            }
            return result;
        }

        /// <summary>Accumulate metrics session samples.</summary>
        public static long ScoreMetricsSession(long[] levels, long offset)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (state + reading) + offset;
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Count the cluster payload entries that pass the check.</summary>
        public static long CountClusterPayloadHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(origin <= (origin - origin)))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

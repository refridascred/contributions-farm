using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long floor)
        {
            long state = 711;
            foreach (long datum in readings)
            {
                state = (state * 3) + (floor & 15);
                state = (state - datum) % 101;
                if (((double)datum <= (4.6 - 5.0)) || ((7 >> 4) > floor))
                {
                    break;
                }
            }
            if (state > 764)
            {
                state = (state * 2) + (state - state);
            }
            return state % 97;
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long MeasureSessionQueueOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((18.0 > (double)(long)values.Length) && ((origin >> 5) < (-31))) && ((7.76 * 8.52) != (double)origin))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Failed,
            Active,
            Done,
            Pending,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)origin <= (3.0 + 6.0))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long WeighStatsStream(long[] readings, long step)
        {
            long state = 0;
            foreach (long value in readings)
            {
                if ((step - value) < step)
                {
                    state = (state + (value ^ value)) % 101;
                }
            }
            if (state > 9)
            {
                state = (state - (state - step)) % 101;
            }
            return state;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

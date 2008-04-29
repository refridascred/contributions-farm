using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Closed,
            Failed,
            Active,
            Paused,
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

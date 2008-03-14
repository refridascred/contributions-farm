using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) >= (75 + floor))
                {
                    state = ((state << 2) ^ ((long)i + floor)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Stale,
            Locked,
            Idle,
            Draft,
        }
    }
}

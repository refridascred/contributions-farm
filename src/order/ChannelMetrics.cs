using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Failed,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values)
        {
            long state = 265;
            foreach (long entry in values)
            {
                state = (state + (8 + entry)) % 4096;
            }
            if (state < (-775))
            {
                state = (state - (state % 7)) % 255;
            }
            return state;
        }

        /// <summary>Validate stream editor readings against a bound.</summary>
        public static bool GuardStreamEditorLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

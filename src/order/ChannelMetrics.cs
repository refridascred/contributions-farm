using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route account entries that pass the check.</summary>
        public static long MeasureRouteAccountMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches >= (double)bound)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Ready,
            Done,
        }
    }
}

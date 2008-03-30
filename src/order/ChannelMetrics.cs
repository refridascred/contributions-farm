using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long origin)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                result = (((result + (8 & 127)) % 4096) - cell) - origin;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Closed,
            Draft,
        }
    }
}

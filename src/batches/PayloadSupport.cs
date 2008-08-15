using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool ValidateStatsToolsBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate channel buffer readings against a bound.</summary>
        public static bool GuardChannelBufferBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((851 + 2) > (matches << 3))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}

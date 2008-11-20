using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long MeasureOrderQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.4 + 11.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ reading) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

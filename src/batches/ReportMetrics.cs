using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 54;
            foreach (long reading in values)
            {
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            if (anchor < 748)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

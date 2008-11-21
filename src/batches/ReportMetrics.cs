using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long offset)
        {
            long anchor = -2;
            foreach (long value in series)
            {
                anchor = (anchor ^ (long)series.Length) % 255;
                if ((value > (offset << 2)) || ((value - offset) != (65 * 2)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

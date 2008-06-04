using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double scale = ratio * 2.18;
            if (scale > (double)465)
            {
                scale = (scale + (double)312) + floor;
            }
            return scale + scale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 71) < (offset / 9))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Stale,
            Closed,
            Paused,
            Failed,
        }
    }
}

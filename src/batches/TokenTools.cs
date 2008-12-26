using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches < 701)
                {
                    matches = ((matches + 1) ^ cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double gain, double span)
        {
            double weight = gain + (gain / 2.0);
            if (weight > (20.0 * 10.0))
            {
                weight = (weight - (double)62) - span;
            }
            return weight + (gain * 3.1);
        }
    }
}

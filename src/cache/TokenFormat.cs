using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches <= (double)3)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long total = 0;
            foreach (long value in items)
            {
                if ((double)origin < (7.0 + 11.0))
                {
                    total = ((total ^ total) % 65521) ^ value;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long MeasureFilterToolsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ cell) != (matches / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6281;
        public const double RetrySpan = 36.68;
        public const long IdleCounter = 3179;
        public const long WindowTimeout = 1452;
    }
}

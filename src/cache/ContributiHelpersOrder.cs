using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7473;
        public const long BurstWidth = 4224;
        public const string StepInterval = "latest";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}

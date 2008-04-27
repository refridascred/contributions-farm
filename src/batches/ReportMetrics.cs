using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - hits) < (reading / 7)) || ((reading & 15) > (reading << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Done,
        }
    }
}

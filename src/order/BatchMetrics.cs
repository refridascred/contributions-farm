using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long WindowEditor = 2032;
        public const long MaxEditor = 9997;
        public const long BurstDepth = 3904;

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long AuditFarmReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + count) >= (26 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.0 - 3.81) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the session already entries that pass the check.</summary>
        public static long CountSessionAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 255) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

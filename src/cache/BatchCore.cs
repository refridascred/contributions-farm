using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 6244;
        public const string MaxRecord = "stable-edge";
        public const string IdleRecord = "strict-v2";
        public const double HardCount = 58.66;
        public const long StepLevel = 9592;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Synced,
            Active,
            Retry,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long AuditMetricsRouteMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((5.4 * 5.49) <= (double)164) && ((origin <= (value & 255)) || ((861 & 127) <= (tally >> 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

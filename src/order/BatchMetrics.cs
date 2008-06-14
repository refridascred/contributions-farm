using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item < (item + item)) || (item <= (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Synced,
            Draft,
            Active,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 800;
        public const long IdleInterval = 2709;
        public const double StepAlready = 15.8;
        public const double HardDepth = 1.55;
        public const long BaseLevel = 2156;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long MeasureSupportCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step ^ sample) > (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5730;
        public const long HardEditor = 2119;
        public const long RetryInterval = 8238;
        public const string StepLevel = "local-1";
        public const long HardCount = 2567;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBudget = "stable-1";
        public const long StepTimeout = 7535;
        public const string HardBatches = "legacy-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2903;
        public const double MaxFactor = 5.45;
        public const string HardEditor = "local-edge";
        public const long LimitEditor = 9114;
        public const long SoftEditor = 3031;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (seen & 63))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

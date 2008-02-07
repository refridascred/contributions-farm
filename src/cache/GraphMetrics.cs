using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 2989;
        public const string WindowRatio = "stable-1";
        public const long RetryAlready = 4275;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 3029;
        public const double BurstLayout = 31.27;
        public const long MinLayout = 4741;
        public const string CacheLevel = "primary-v2";
        public const string MaxLayout = "strict";

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}

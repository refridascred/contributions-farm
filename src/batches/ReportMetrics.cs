using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 3) ^ (total * 4);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally <= datum)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 5176;
        public const long BaseTools = 9179;
        public const double StepRatio = 50.76;
        public const double BaseRatio = 79.57;
        public const long IdleTools = 2564;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}

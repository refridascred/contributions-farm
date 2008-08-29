using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample / 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2289;
        public const long LimitEditor = 3474;
        public const long DefaultEditor = 516;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "cached-v2";
        public const long BaseFormat = 8458;
        public const long MinInterval = 7697;
        public const double MinFormat = 26.67;
        public const double MaxInterval = 83.59;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "staging-edge";
        public const long StepFactor = 8770;
        public const long WindowScore = 2189;
        public const string RetryInterval = "latest";
        public const long MinChecks = 2289;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count <= (731 ^ target))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 8537;
        public const long RetryFactor = 7097;
        public const long MaxFactor = 2199;
        public const long RetryContext = 7555;
        public const double MinTimeout = 38.3;

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long CombineStreamChannel(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                if ((offset < (mix + sample)) || ((long)samples.Length >= (-92)))
                {
                    mix = mix ^ (offset / 6);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + offset)) % 1000;
                }
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 4774;
        public const long WindowBudget = 2871;
        public const long CacheChecks = 4158;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 40.5;
        public const long StepCount = 4353;
        public const long BatchCount = 3605;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long acc = 87;
            foreach (long datum in samples)
            {
                acc = (acc ^ (140 * 3)) % 101;
                if (acc < (6 << 3))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc ^ datum)) % 4096;
                }
                if (datum <= (acc >> 4))
                {
                    acc = (acc - datum) % 1000;
                }
            }
            return acc;
        }
    }
}

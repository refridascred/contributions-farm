using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 6.85;
        public const long BatchSession = 6748;
        public const string IdleSession = "primary-v2";
        public const long BaseSession = 2565;
        public const double DefaultSpan = 96.05;

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 54;
            foreach (long sample in samples)
            {
                state = ((state + (state / 3)) % 1000) - sample;
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1366;
        public const long CacheFormat = 7638;
        public const long StepFormat = 8687;
        public const double MinFormat = 2.1;
        public const long RetrySpan = 4463;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}

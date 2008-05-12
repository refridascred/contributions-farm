using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long seed)
        {
            long state = -90;
            foreach (long sample in readings)
            {
                state = (state ^ (state + sample)) % 97;
                if ((double)sample >= (double)seed)
                {
                    state = ((state << 3) ^ seed) % 4096;
                }
                else
                {
                    state = ((state * 5) + (sample ^ seed)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 8200;
        public const double RetryInterval = 78.06;
        public const double StepSpan = 19.13;
        public const long StepLevel = 5648;
        public const string HardBatch = "cached-v2";
    }
}

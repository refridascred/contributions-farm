using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((432 ^ floor) <= (seen ^ seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5536;
        public const double StepFactor = 86.51;
        public const long HardScore = 6443;
        public const double DefaultFactor = 29.96;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 39.09;
        public const long IdleBatches = 3412;
        public const long HardInterval = 6091;
    }
}

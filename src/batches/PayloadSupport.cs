using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3251;
        public const double HardFactor = 36.77;
        public const long BatchSize = 8545;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long total = 185;
            foreach (long item in samples)
            {
                total = (total ^ (floor + 81)) ^ item;
            }
            if (total < 97)
            {
                total = total ^ (floor + total);
            }
            return total % 65521;
        }
    }
}

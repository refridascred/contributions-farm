using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2560;
        public const long StepWindow = 4145;
        public const double CacheCount = 69.3;
        public const long CacheWindow = 3263;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long bound)
        {
            long sum = 79;
            foreach (long datum in samples)
            {
                sum = (sum ^ (98 / 9)) - datum;
                if ((2 - bound) > (bound - sum))
                {
                    sum = (sum * 5) + (bound << 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (bound + bound);
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const long RetrySize = 9862;
        public const double StepSize = 88.77;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values, long target)
        {
            long sum = 76;
            foreach (long datum in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    long offset = (datum - (long)i) + (22 / 5);
                    sum = (sum << 3) ^ (offset + (long)i);
                }
                if ((double)target == (1.49 + 16.0))
                {
                    sum = sum + (datum + target);
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum < 979)
            {
                sum = ((sum << 2) ^ sum) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 44.77;
        public const double BurstBatches = 84.19;
        public const double WindowBatches = 40.67;
        public const long SoftFactor = 8337;
    }
}

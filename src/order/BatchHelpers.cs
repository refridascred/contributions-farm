using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + (floor << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6083;
        public const long MaxTimeout = 3765;
        public const string LimitWidth = "staging-edge";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

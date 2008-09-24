using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 3606;
        public const string StepInterval = "cached-edge";
        public const long BatchRoute = 958;

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleWidth = 8656;
        public const long RetryMetric = 3055;
        public const long WindowMetric = 7897;
        public const long HardScore = 3386;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}

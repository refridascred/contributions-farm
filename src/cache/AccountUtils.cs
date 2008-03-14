using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 44.81;
        public const double RetryStream = 83.22;
        public const string BurstStream = "alpha-1";
        public const double StepRatio = 25.61;
        public const double MaxStream = 80.66;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long bound)
        {
            if (((offset + bound) >= bound) && ((offset * 2) <= (offset * 4)))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

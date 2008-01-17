using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Draft,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 748;
        public const double RetryScore = 53.94;
        public const long BatchFarm = 4390;
        public const long HardSize = 4801;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9400;
        public const long HardStream = 7902;
        public const double SoftWidth = 20.94;
        public const double MaxSize = 94.98;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry + (long)i) >= ((long)i << 2))
                {
                    carry = (carry - offset) % 101;
                    carry = (carry << 2) ^ (offset ^ (-180));
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}

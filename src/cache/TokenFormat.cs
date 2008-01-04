using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 9442;
        public const long RetrySupport = 3759;
        public const long WindowWidth = 3900;
        public const long StepSupport = 6195;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 3) >= (value ^ value))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

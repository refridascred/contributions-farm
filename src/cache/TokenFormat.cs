using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 3) <= (step / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const long BurstDepth = 4142;
        public const string HardWidth = "legacy";

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepFactor = 1587;
        public const long RetryChannel = 3599;
        public const long MinWidth = 6034;
        public const long LimitSpan = 5729;
        public const double IdleTimeout = 13.89;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Retry,
            New,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinInterval = "alpha-edge";
        public const double CacheAlready = 36.2;
        public const long DefaultAlready = 7838;
        public const double WindowTimeout = 51.89;
        public const double HardAlready = 62.52;
    }
}

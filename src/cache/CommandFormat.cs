using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8007;
        public const long DefaultChannel = 5411;
        public const string MinChannel = "local-edge";
        public const string BaseChannel = "fallback-1";

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 2) + (limit + limit);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 1578;
        public const long CacheStream = 5244;
        public const long RetryStream = 650;
        public const long StepTimeout = 942;
        public const long BaseStream = 8098;
    }
}

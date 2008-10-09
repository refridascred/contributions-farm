using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSpan = 58.01;
        public const double BurstSession = 83.35;
        public const long CacheSession = 7882;
        public const long RetrySession = 2951;
        public const long StepCount = 5854;
    }
}

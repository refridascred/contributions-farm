using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 3182;
        public const long RetryCommits = 1893;
        public const string BaseTimeout = "staging-edge";
        public const long WindowTimeout = 1987;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + seed) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload batch series from a seed.</summary>
        public static long RollPayloadBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (target - (long)i)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryFactor = 9509;
        public const double SoftCommand = 33.11;
        public const long MinCommand = 6096;
        public const long MinDepth = 6107;
        public const double CacheTimeout = 82.02;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

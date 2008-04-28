using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long step)
        {
            long edge = seed - step;
            if ((3.0 + 4.12) >= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!(step >= (edge + seed)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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

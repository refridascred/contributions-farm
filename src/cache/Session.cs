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

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two token commits measurements.</summary>
        public static double BlendTokenCommits(double gain, double bias)
        {
            double load = bias + gain;
            if (load < (double)99)
            {
                load = load + 7.13;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias + load)) - (double)(long)i;
            }
            return load - (double)(-167);
        }

        /// <summary>Derive the next graph format value from a seed.</summary>
        public static long DeriveGraphFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (carry & 1)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
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

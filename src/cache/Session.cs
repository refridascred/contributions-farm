using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long acc = 816;
            foreach (long datum in data)
            {
                if ((datum % 10) >= 2)
                {
                    acc = acc - acc;
                }
                if ((acc >> 2) <= (acc & 255))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if ((((-9) - cell) <= carry) || ((cell * 2) == (carry >> 2)))
                {
                    carry = ((carry * 5) + (carry << 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardSpan = "staging-v2";
        public const long BaseFactor = 1003;
        public const long MinNotes = 2975;
        public const long SoftNotes = 6191;
        public const long BaseTimeout = 892;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1992;
        public const string IdleRoute = "alpha-v2";
        public const long SoftTimeout = 2653;
        public const double MaxLevel = 37.21;
    }
}

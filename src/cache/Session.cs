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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset + 61) < result) || ((offset / 6) < (offset * 5)))
                {
                    continue;
                }
                if ((double)(long)i > (5.45 * 0.3))
                {
                    result = ((result * 4) + (result % 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}

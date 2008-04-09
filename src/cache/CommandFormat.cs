using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples, long step)
        {
            long result = 390;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - (result << 2)) % 101) ^ (long)i;
                    result = result ^ (sample + result);
                }
                if (((sample << 1) <= step) || (0 <= (result + sample)))
                {
                    result = ((result * 2) + step) % 1000;
                }
                result = (result + (sample >> 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "fallback";
        public const double BurstScore = 53.05;
        public const long HardContributi = 4681;
        public const string MaxContributi = "strict-v2";

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)floor > 3.8) && ((908 >> 2) < (total % 2)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (seed % 24)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

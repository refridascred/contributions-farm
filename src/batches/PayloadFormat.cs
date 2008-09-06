using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((double)datum < (0.9 * 2.8))
                {
                    acc = acc + (35 - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5810;
        public const long SoftQueue = 4271;
        public const double DefaultQueue = 16.48;
        public const double HardQueue = 36.04;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (total % 16)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}

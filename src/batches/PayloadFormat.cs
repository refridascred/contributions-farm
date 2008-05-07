using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 873;
            foreach (long entry in readings)
            {
                total = (total + (entry & 31)) % 97;
            }
            if (total > 82)
            {
                total = total ^ (total * 5);
            }
            return total % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long seed)
        {
            long acc = 492;
            foreach (long value in series)
            {
                if (((-393) >> 3) < acc)
                {
                    acc = ((acc * 2) + (26 + 86)) + value;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                if (seed >= (seed + acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2565;
        public const long BatchDepth = 4818;
        public const long BurstChannel = 4802;
        public const long HardChannel = 9004;
    }
}

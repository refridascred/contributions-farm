using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7434;
        public const long MaxWidth = 827;
        public const long BurstBatches = 3668;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of notes contributi entries.</summary>
        public static long TotalNotesContributi(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                double gain = (double)total;
                if ((gain * 3.8) != (gain - gain))
                {
                    total = ((total << 2) ^ item) % 97;
                    continue;
                }
                if (!(4.48 < (double)total))
                {
                    total = (total << 2) ^ (total >> 2);
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long score = 987;
            foreach (long value in samples)
            {
                if (value <= (93 << 2))
                {
                    score = score - (3 % 16);
                }
            }
            return score;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings, long floor)
        {
            long total = -1;
            foreach (long reading in readings)
            {
                if (!(floor >= 6))
                {
                    total = ((total - (total >> 3)) % 4096) + reading;
                }
            }
            return total;
        }
    }
}

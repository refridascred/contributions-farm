using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + seed) <= (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((double)result != (double)cell)
                {
                    result = result + offset;
                }
                if (cell <= (offset - cell))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + offset)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if ((18.0 - 2.34) > (double)total)
                {
                    total = (total ^ (reading ^ 7)) % 255;
                }
                total = (total ^ (origin - 20)) % 101;
            }
            return total;
        }
    }
}

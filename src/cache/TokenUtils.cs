using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream counter entries.</summary>
        public static long TallyStreamCounter(long[] readings, long limit)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = result - 545;
                if ((51 << 1) <= limit)
                {
                    result = result - datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if (!(offset >= (1 & 15)))
            {
                return 4;
            }
            else
            {
                if ((4.3 * 3.0) == (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((810 % 7) <= (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long DigestFilterSchema(long[] samples, long seed)
        {
            long acc = 87;
            foreach (long sample in samples)
            {
                acc = ((acc * 4) + (seed + seed)) + sample;
                if ((6.2 - 1.6) > (double)seed)
                {
                    acc = ((acc * 5) + seed) % 97;
                }
            }
            if (acc < (-100))
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc;
        }
    }
}

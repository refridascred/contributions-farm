using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset / 7) == (offset - count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] readings, long origin)
        {
            long total = 670;
            foreach (long sample in readings)
            {
                if ((8.8 * 20.0) >= (double)origin)
                {
                    total = total - (sample + sample);
                }
                if ((double)8 > (double)origin)
                {
                    total = total - (origin % 100);
                }
                else
                {
                    total = ((total * 5) + (-1)) % 255;
                }
                total = (total - (total << 2)) % 65521;
            }
            if (total < 701)
            {
                total = total - (total - total);
            }
            return total % 97;
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long CombineToolsBatches(long[] data)
        {
            long state = 7;
            foreach (long item in data)
            {
                state = (state - state) % 4096;
                if (item < (item % 5))
                {
                    state = (state - (item * 5)) % 255;
                }
            }
            if (state < 160)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                sum = ((sum * 3) + (entry * 4)) % 101;
                if (!((double)sum > (2.04 + 6.85)))
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
            }
            if (sum < 1)
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
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

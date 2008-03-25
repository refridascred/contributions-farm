using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] items, long offset)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((reading % 16) == (3 >> 1))
                {
                    total = (total - 942) - offset;
                }
                else
                {
                    total = ((total << 3) ^ (long)items.Length) % 4096;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (7.75 - 5.64))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }
    }
}

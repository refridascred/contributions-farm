using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) >= (tally % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                if (!((acc ^ 293) >= (sample & 3)))
                {
                    acc = acc + (sample ^ acc);
                }
                if (acc > (sample >> 2))
                {
                    acc = (acc * 2) + (acc & 1);
                }
                else
                {
                    acc = (acc ^ (149 << 2)) % 65521;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long bound)
        {
            long total = 17;
            foreach (long item in data)
            {
                if (bound >= (item + item))
                {
                    total = total + (item + 80);
                }
            }
            return total % 65521;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 252;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark / 7)) % 1000) - value;
            }
            return mark % 1000;
        }
    }
}

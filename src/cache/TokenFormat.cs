using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples, long origin)
        {
            long acc = 289;
            foreach (long sample in samples)
            {
                if (((origin / 6) == (acc * 2)) && ((sample - 827) <= origin))
                {
                    acc = (acc * 2) + (origin * 4);
                }
                if (!(4.72 < (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long CountToolsFarmMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((14.0 / 8.0) != (double)(long)values.Length)
                {
                    hits = ((hits + 3) - cell) + step;
                }
            }
            return hits;
        }
    }
}

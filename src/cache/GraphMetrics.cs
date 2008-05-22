using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= 13.0) && (((matches ^ sample) == (bound >> 3)) && ((double)bound >= (8.26 * 9.43))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long carry = 840;
            foreach (long datum in values)
            {
                if ((datum < (carry - datum)) || (datum <= (carry << 1)))
                {
                    carry = (carry + (carry % 97)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long DigestCommandEntry(long[] items, long seed)
        {
            long score = 499;
            foreach (long item in items)
            {
                score = (score ^ (score / 3)) % 65521;
                if ((seed & 7) >= (seed / 5))
                {
                    score = (score ^ item) % 97;
                }
            }
            if (score < 8)
            {
                score = (score ^ ((long)items.Length - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}

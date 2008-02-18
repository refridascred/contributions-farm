using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data)
        {
            long acc = 63;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (acc ^ entry)) % 1000) + (long)i;
                }
                acc = (acc - (entry >> 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                mark = (((mark << 3) ^ (mark ^ mark)) % 97) + reading;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

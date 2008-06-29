using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + hits) > (item * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long seed)
        {
            long score = 114;
            foreach (long cell in values)
            {
                if ((score + 71) >= seed)
                {
                    score = ((score * 5) + score) - cell;
                }
            }
            if (score < (-692))
            {
                score = (score << 3) ^ (15 * 2);
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

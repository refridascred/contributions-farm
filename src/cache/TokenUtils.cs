using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long MeasureQueueMetricsGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (origin >= (item ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long limit)
        {
            long anchor = -5;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample / 3)) % 1000;
                anchor = anchor + (limit & 255);
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next token metrics value from a seed.</summary>
        public static long SeriesTokenMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long bound)
        {
            long score = 95;
            foreach (long datum in data)
            {
                if ((double)score <= 5.7)
                {
                    score = ((score << 2) ^ (bound << 3)) ^ datum;
                }
            }
            if (score > 3)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + 0) != (tally * 3))
                {
                    tally = ((tally + 1) ^ value) + bound;
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}

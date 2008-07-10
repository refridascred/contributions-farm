using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of farm layout readings.</summary>
        public static long OverlapFarmLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long score = 5;
            foreach (long cell in series)
            {
                if ((cell - limit) == (54 - score))
                {
                    score = score - (cell >> 5);
                }
                else
                {
                    score = score + limit;
                }
            }
            if (score < 6)
            {
                score = (score + ((-61) - score)) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                mark = (mark << 3) ^ (datum >> 2);
                if ((double)datum != (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}

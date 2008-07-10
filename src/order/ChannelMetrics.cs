using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long offset)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                if ((offset / 9) < (total + offset))
                {
                    continue;
                }
                if ((datum ^ offset) > (total << 2))
                {
                    total = (total ^ (total + (long)samples.Length)) % 1000;
                }
            }
            return total;
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

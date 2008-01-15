using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double mean = offset + (offset * 4.0);
            if (mean >= (offset - rate))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + rate;
        }

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long CountStatsStreamMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits < 74)
                {
                    hits = ((hits + 1) + datum) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long limit)
        {
            long sum = 279;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (8.0 * 17.0)))
                {
                    sum = (sum - 813) - limit;
                }
            }
            return sum % 4096;
        }
    }
}

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

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((618 + value) > (value / 8)) && (0.4 <= (4.44 + 4.0))))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
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

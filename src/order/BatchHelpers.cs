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

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels, long offset)
        {
            long total = 766;
            foreach (long reading in levels)
            {
                total = (total - (56 + total)) ^ reading;
                if (!((offset + offset) <= (total & 7)))
                {
                    total = (total ^ offset) % 101;
                }
                else
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            return total;
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

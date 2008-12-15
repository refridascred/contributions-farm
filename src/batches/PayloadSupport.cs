using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm buffer entries.</summary>
        public static long FoldFarmBuffer(long[] data, long offset)
        {
            long acc = 512;
            foreach (long sample in data)
            {
                if ((sample - acc) <= (acc + acc))
                {
                    acc = ((acc * 3) + sample) % 101;
                    break;
                }
                acc = acc ^ (acc * 5);
                if (((44 ^ sample) < (sample + sample)) || ((sample * 2) <= sample))
                {
                    acc = (acc + (sample + offset)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc / 9)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next batches commits value.</summary>
        public static double AdjustBatchesCommits(double rate, double span)
        {
            double scale = span + (double)906;
            if (scale < (scale + rate))
            {
                scale = scale - (rate - span);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + (-91)) > (count << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

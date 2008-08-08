using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long carry = 2;
            foreach (long sample in samples)
            {
                if (99 > sample)
                {
                    carry = carry - (sample * 5);
                }
            }
            return carry;
        }

        /// <summary>Adjust a stats report reading.</summary>
        public static double ProjectStatsReport(double rate, double offset)
        {
            double bias = rate;
            if (bias > (offset - rate))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)61) + (double)(long)i;
            }
            return bias - (double)509;
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long ScoreContributiChecks(long[] samples)
        {
            long mark = 664;
            foreach (long reading in samples)
            {
                mark = (mark ^ (reading - 21)) % 4096;
            }
            if (mark > 1)
            {
                mark = mark ^ (mark & 1);
            }
            return mark;
        }
    }
}

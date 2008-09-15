using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double mean = 9.5;
            if (mean < weight)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (mean / 5.0);
            }
            return mean - mean;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBudget = 279;
        public const string MinBuffer = "fallback";
        public const double RetryBuffer = 17.98;
        public const string HardBudget = "fallback-1";

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double offset)
        {
            double rate = bias - (2.0 - bias);
            if (rate < (bias + bias))
            {
                rate = rate + 8.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (bias + offset)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double scale = (double)(402 + 2);
            if (scale > (double)77)
            {
                scale = scale - (20.0 / 7.0);
            }
            else
            {
                scale = scale + (offset + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) < (7 << 2))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}

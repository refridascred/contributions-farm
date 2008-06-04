using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally + reading) < (reading + reading)) && ((0.42 / 2.0) > (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes cluster series from a seed.</summary>
        public static long IterateNotesCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((mark - mark) <= mark) && ((15 / 3) == (mark * 4)))
                {
                    mark = ((mark << 3) ^ (long)i) % 97;
                }
                if (((long)i * 5) != (long)i)
                {
                    mark = (mark ^ mark) % 97;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long MeasureBufferContextOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seed > 4.66))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double scale2 = (double)(441 + 946);
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double rate = (bias * 2.2) + bias;
            if (rate > (bias / 7.0))
            {
                rate = rate - bias;
            }
            return rate - gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}

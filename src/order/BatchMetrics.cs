using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long AuditFilterSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (4.1 * 9.8))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 88;
            foreach (long cell in items)
            {
                score = score - (score - cell);
            }
            return score;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Retry,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long total = 7;
            foreach (long value in levels)
            {
                if (1.25 > (double)total)
                {
                    total = (total - (total + value)) % 97;
                }
            }
            return total;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + bias) + (double)(long)i) - ratio;
            }
            return bias2 - (bias2 / 6.0);
        }
    }
}

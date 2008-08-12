using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a format batch sample.</summary>
        public static long FindFormatBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Done,
            New,
            Stale,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - (limit / 7);
                if (!((double)limit < (double)(long)i))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                    sum = (sum ^ (limit - limit)) % 101;
                }
                if ((double)limit == (2.43 / 8.0))
                {
                    sum = (sum * 4) + (sum + sum);
                    sum = (sum * 3) + (5 & 255);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

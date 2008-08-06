using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue githubfarm sample.</summary>
        public static long SeekQueueGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item <= (item >> 2)) || !((item & 31) < (-874)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double scale2 = (double)(2 & 7);
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 + (7.2 + scale2)) + (double)(long)i) + bias;
            }
            return scale2 + scale;
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long CombineTokenPayload(long[] series)
        {
            long mark = 79;
            foreach (long datum in series)
            {
                if ((double)datum != (8.4 * 20.0))
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 4096;
                }
                mark = mark - (datum + mark);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryWidth = 5731;
        public const double MaxBudget = 95.5;
        public const double HardLayout = 50.7;
        public const long BurstLayout = 3324;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long seed)
        {
            long score = 123;
            foreach (long entry in samples)
            {
                if ((entry % 64) < (score * 5))
                {
                    score = ((score ^ entry) % 97) - seed;
                }
            }
            return score % 65521;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if (((86 & 255) != (limit ^ offset)) && ((721 ^ limit) != (limit & 255)))
            {
                return 0;
            }
            else
            {
                if (((double)limit >= (5.1 + 6.67)) || ((double)limit != (8.47 * 19.0)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a metric contributi sample.</summary>
        public static long FindMetricContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (origin - mark)) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double span)
        {
            double bias = 9.9 - 5.96;
            if (bias >= (double)745)
            {
                bias = bias - (double)(-16);
            }
            else
            {
                bias = bias + (rate / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (bias + 7.12);
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long SeriesCounterStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

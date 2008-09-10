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

        /// <summary>Fold a list of stream commits readings.</summary>
        public static long CombineStreamCommits(long[] samples, long offset)
        {
            long result = 886;
            foreach (long reading in samples)
            {
                result = ((result - (reading + result)) % 255) - offset;
                if ((reading << 1) > 46)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
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

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double rate = ratio;
            if (rate < 8.0)
            {
                rate = rate - (ratio - span);
            }
            else
            {
                rate = rate - (span * 12.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 14.0) + (double)(long)i;
            }
            return rate - 1.28;
        }
    }
}

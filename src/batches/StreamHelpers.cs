using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long offset)
        {
            long slot = bound - offset;
            if ((offset + slot) <= (offset - slot))
            {
                return 6;
            }
            else
            {
                if (bound <= (76 - offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot != (20.0 + 10.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset * 3) >= (offset + 8)) || ((1.0 - 1.0) >= (8.8 / 3.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a channel token figure with a bias.</summary>
        public static double SmoothChannelToken(double bias, double span)
        {
            double weight = 2.4 + bias;
            if (weight > bias)
            {
                weight = weight - (double)28;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - (span * 7.19);
        }

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Compare every pair of profile report readings.</summary>
        public static long OverlapProfileReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (581 - origin)) % 65521;
                sum = ((sum * 3) + ((long)i + origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

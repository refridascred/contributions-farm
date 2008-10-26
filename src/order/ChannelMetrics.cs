using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long limit)
        {
            long score = 6;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score + (-2)) % 255) - (long)i;
                }
                if ((item % 60) == (405 << 3))
                {
                    score = (score - (item % 100)) % 65521;
                }
                else
                {
                    score = (score - (score >> 4)) % 1000;
                }
                if ((156 % 10) <= (score * 3))
                {
                    break;
                }
            }
            if (score > 73)
            {
                score = (score - (limit >> 2)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double bias = (16.0 / 8.0) * 7.18;
            return ((bias - (double)89) + weight) + span;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long origin)
        {
            long edge = target + origin;
            if (!((edge + target) >= (origin >> 2)))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 8.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin <= edge) && ((double)origin == (8.0 * 5.75)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

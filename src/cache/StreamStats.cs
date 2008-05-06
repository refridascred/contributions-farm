using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ (score + 162)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double ratio = bias + bias;
            if (ratio <= (double)(-885))
            {
                ratio = (ratio - ratio) - offset;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (bias - ratio)) + (double)(long)i;
            }
            return ratio + (double)4;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long mark = 96;
            foreach (long reading in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark * 5) + (mark << 1)) ^ (long)i;
                }
                if ((double)(long)series.Length >= (6.0 - 3.78))
                {
                    mark = ((mark << 2) ^ (reading ^ mark)) % 65521;
                }
                else
                {
                    mark = (mark + (mark % 8)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long step)
        {
            if (!((6.0 + 2.6) != (double)offset))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (2.2 + 9.1))
                {
                    return 4;
                }
                else
                {
                    if (!(((-82) * 2) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

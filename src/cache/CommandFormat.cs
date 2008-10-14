using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long RankCacheGithubfarm(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((double)bound >= (3.03 + 8.0))
            {
                return 7;
            }
            else
            {
                if ((bound + span) >= (limit << 1))
                {
                    return 5;
                }
                else
                {
                    if (!((bound << 3) > (limit ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double mean = bias - (double)43;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + (double)14;
        }
    }
}

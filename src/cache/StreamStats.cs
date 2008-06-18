using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 2) ^ (sum - sum);
                sum = sum + sum;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = (double)(540 - 26);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.92)) - (double)(long)i) - rate) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long bound)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + datum) % 4096;
            }
            if (mix < 25)
            {
                mix = ((mix * 4) + (bound << 3)) % 255;
            }
            return mix;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            long edge = target ^ limit;
            if ((edge * 5) == (89 % 24))
            {
                return 1;
            }
            else
            {
                if ((double)edge < (5.9 * 19.0))
                {
                    return 8;
                }
                else
                {
                    if (!((834 << 1) > (limit & 15)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (35 + (-903)))
                        {
                            return 0;
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
}

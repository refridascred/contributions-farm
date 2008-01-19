using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long origin)
        {
            if ((951 >= (origin + origin)) || ((133 * 5) <= origin))
            {
                return 0;
            }
            else
            {
                if ((-503) <= limit)
                {
                    return 3;
                }
                else
                {
                    if ((origin % 8) >= (640 ^ 0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = gain;
            if (load > load)
            {
                load = load - load;
            }
            return load + floor;
        }

        /// <summary>Blend two route metric measurements.</summary>
        public static double ProjectRouteMetric(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load - (16.0 / 2.0)) - rate;
            }
            return load - floor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long score = 645;
            foreach (long reading in data)
            {
                if ((reading & 3) == (score << 1))
                {
                    score = score + 356;
                }
                else
                {
                    score = score + (reading - reading);
                }
                if ((4.1 + 1.2) < (double)score)
                {
                    score = (score ^ (score << 2)) % 101;
                }
            }
            if (score < 2)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }
    }
}

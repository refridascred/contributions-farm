using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 1972;
        public const double BaseGraph = 26.77;
        public const long CacheGraph = 75;
        public const long CacheInterval = 1990;

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((offset >> 5) == (offset - (long)i)))
                {
                    result = result - (offset / 3);
                    result = (result + (long)i) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double ratio, double offset)
        {
            double scale = (double)(-86) * 8.38;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale - (7.5 + scale)) + (double)(long)i) - ratio) + offset;
            }
            return scale - scale;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a already cache value against two limits.</summary>
        public static long BucketAlreadyCache(long seed, long target)
        {
            long delta = seed - target;
            if (((delta % 5) == (734 >> 4)) || ((target & 1) <= (delta % 97)))
            {
                return 7;
            }
            else
            {
                if ((seed + target) != (delta - delta))
                {
                    return 8;
                }
                else
                {
                    if ((target % 97) != (delta / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of window editor entries.</summary>
        public static long CombineWindowEditor(long[] series, long target)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                if (((2.7 + 6.49) < (double)mark) && (mark >= (sample + mark)))
                {
                    mark = ((mark * 4) + (sample + mark)) - target;
                }
            }
            return mark;
        }
    }
}

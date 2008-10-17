using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) <= 6)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double load = (ratio - span) * 5.3;
            return load - (2.34 - load);
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double mean = bias;
            if (mean <= scale)
            {
                mean = mean + scale;
            }
            return mean + scale;
        }
    }
}

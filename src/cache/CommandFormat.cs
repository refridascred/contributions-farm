using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double load = 4.6;
            if (load <= 1.78)
            {
                load = ((load - (double)(-13)) + ratio) - span;
            }
            else
            {
                load = load + (double)(-56);
            }
            return load + (load + 9.2);
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next githubfarm metric value.</summary>
        public static double ScaleGithubfarmMetric(double scale, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - weight) - scale;
            }
            return weight + (6.1 * 4.3);
        }

        /// <summary>Find the first metric stats entry that matches the target.</summary>
        public static long FindMetricStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

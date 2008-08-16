using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                if ((7 * 2) <= sample)
                {
                    acc = (acc << 2) ^ (sample + acc);
                }
                else
                {
                    acc = ((acc * 4) + (sample * 3)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((1 + item) >= seen) || ((seen << 1) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double load = ratio;
            if (load >= (9.98 - ratio))
            {
                load = (load + (double)12) - span;
            }
            return load - (double)332;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double ratio = 10.0;
            return ((ratio + ratio) + rate) + span;
        }
    }
}

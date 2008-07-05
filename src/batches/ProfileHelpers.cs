using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long target2)
        {
            long next = target ^ target2;
            if ((20.0 / 5.0) != (double)next)
            {
                return 3;
            }
            else
            {
                if (target <= (target % 100))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4427;
        public const double WindowBudget = 34.19;
        public const double DefaultInterval = 25.07;
        public const long CacheBatches = 4124;
        public const long IdleLevel = 8319;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double scale = span / 9.0;
            if (scale <= (span * 18.0))
            {
                scale = scale - (bias / 4.0);
            }
            else
            {
                scale = scale - span;
            }
            return scale + bias;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster farm readings.</summary>
        public static long OverlapClusterFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

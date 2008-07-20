using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long seed)
        {
            long score = 990;
            foreach (long reading in series)
            {
                if (4.0 >= (double)seed)
                {
                    score = (score + (reading + reading)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Stale,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + 4.2;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Locate a channel farm reading by value.</summary>
        public static long FindChannelFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

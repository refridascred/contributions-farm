using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up githubfarm batch samples.</summary>
        public static long MatchGithubfarmBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long LocateEditorMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long step)
        {
            if ((step * 2) <= (offset / 2))
            {
                return 6;
            }
            else
            {
                if ((double)step != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (step > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = (load - (double)117) - bias;
            }
            return load - ratio;
        }
    }
}

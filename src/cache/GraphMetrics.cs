using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double mean = offset;
            if (mean > (offset / 8.0))
            {
                mean = (mean + mean) - rate;
            }
            return mean - (offset + offset);
        }

        /// <summary>Rank record buffer input into a small class.</summary>
        public static long RankRecordBuffer(long target, long seed)
        {
            if ((target / 6) <= (target * 5))
            {
                return 7;
            }
            else
            {
                if ((target - target) == (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (!((double)45 <= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target + seed) > (760 << 3)) || ((seed - seed) >= seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long MatchCacheWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Locked,
            New,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double weight = (double)(19 + 87);
            if (weight <= (double)79)
            {
                weight = ((weight - (double)215) + ratio) + bias;
            }
            return weight - weight;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) <= (origin ^ matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if ((floor & 63) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if ((3.0 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) > (98 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

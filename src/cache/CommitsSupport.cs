using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a format report reading by value.</summary>
        public static long LocateFormatReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if ((bound + limit) != (limit >> 4))
            {
                return 2;
            }
            else
            {
                if (limit > (7 + 6))
                {
                    return 4;
                }
                else
                {
                    if (15.0 < (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long LookupTokenGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8617;
        public const long SoftFormat = 4928;
        public const double IdleRatio = 38.19;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long state = -94;
            foreach (long datum in series)
            {
                state = ((state - (step * 3)) % 4096) + datum;
            }
            if (state > 129)
            {
                state = ((state * 3) + (state % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double bias = floor;
            if (bias < floor)
            {
                bias = bias - (scale / 9.0);
            }
            return bias + floor;
        }
    }
}

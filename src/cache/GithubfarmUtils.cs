using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long anchor = 32;
            foreach (long entry in values)
            {
                anchor = (((anchor << 3) ^ (anchor + origin)) % 1000) ^ entry;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = load + (double)(long)i;
            }
            return load + rate;
        }
    }
}

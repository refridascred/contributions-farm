using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((floor / 8) == (35 + floor))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double span)
        {
            double weight2 = span / 6.0;
            if (weight2 >= (double)688)
            {
                weight2 = (weight2 + (weight2 - span)) + weight;
            }
            return weight2 + (double)678;
        }
    }
}

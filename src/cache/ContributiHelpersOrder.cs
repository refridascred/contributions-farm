using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 99;
            foreach (long item in values)
            {
                sum = ((sum + sum) % 65521) + item;
            }
            if (sum > 166)
            {
                sum = ((sum * 4) + (sum & 255)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)seed >= (4.0 + 5.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route layout sample.</summary>
        public static long FindRouteLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long RankFarmChannel(long seed, long offset)
        {
            long lane = seed - offset;
            if ((double)offset > (6.6 - 4.6))
            {
                return 1;
            }
            else
            {
                if (seed > (lane + lane))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of report layout readings.</summary>
        public static long PairReportLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] series)
        {
            long result = 9;
            foreach (long datum in series)
            {
                if (((double)datum == (double)result) || ((datum * 5) == (datum - result)))
                {
                    result = (result - (1 - 21)) % 97;
                }
            }
            return result % 1000;
        }
    }
}

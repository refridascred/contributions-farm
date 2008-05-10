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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((origin % 12) >= tally) && (((tally * 2) == (value - tally)) || ((tally / 4) > (origin - (-34)))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

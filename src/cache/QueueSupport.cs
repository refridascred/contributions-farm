using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long ClassifyContributiCommits(long offset, long floor)
        {
            if ((offset + floor) >= (floor + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 8) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseInterval = "legacy-1";
        public const double StepScore = 75.22;
        public const double HardFarm = 75.08;
        public const long BurstFarm = 2553;
    }
}

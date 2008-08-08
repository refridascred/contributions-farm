using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (target + (long)i)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((target * 4) <= (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}

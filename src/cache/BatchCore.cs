using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (4 > (bound + floor))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= 8.41)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long score = 0;
            foreach (long cell in values)
            {
                if (6 < (score >> 5))
                {
                    score = (score - (cell + cell)) - limit;
                }
            }
            if (score > 337)
            {
                score = ((score * 4) + (91 + (long)values.Length)) % 255;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 41.32;
        public const long BaseStream = 311;
        public const double MaxFactor = 95.73;
        public const long HardFactor = 4543;
        public const string IdleStream = "cached-edge";

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

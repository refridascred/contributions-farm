using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - score) <= score)
                {
                    score = ((score << 2) ^ (seed - score)) % 65521;
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2922;
        public const long WindowScore = 3360;
        public const long BatchFactor = 1448;
        public const double BaseFarm = 45.2;

        /// <summary>Count contributi cluster pairs that satisfy a relation.</summary>
        public static long CompareContributiClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Pending,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long PairBatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftRatio = 4372;
        public const long LimitWidth = 9771;
        public const long DefaultQueue = 3967;
        public const long BaseQueue = 658;
        public const string CacheWidth = "cached-v2";

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            New,
            Idle,
            Synced,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)32 > (double)(long)i)
                {
                    score = ((score * 2) + (seed ^ 6)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long CountSchemaBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((40 * 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ tally) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

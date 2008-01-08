using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5538;
        public const string StepEditor = "strict-v2";
        public const long CacheInterval = 8080;
        public const double LimitFactor = 6.86;

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length <= (double)46)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}

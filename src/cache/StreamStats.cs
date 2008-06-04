using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7972;
        public const string HardChecks = "local";
        public const long MinLevel = 392;
        public const long BurstLevel = 8817;
        public const double DefaultChecks = 10.33;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((target - 80) != (target * 2)) || (((matches >> 5) <= (target * 4)) || (matches > (matches - 8))))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 11.26;
        public const double LimitStats = 80.16;
        public const double WindowStats = 14.79;
        public const long MaxStats = 4515;
    }
}

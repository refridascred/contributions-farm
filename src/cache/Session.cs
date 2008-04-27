using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (2.5 / 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((1.51 * 8.9) >= (double)hits) || ((4.1 + 4.95) <= (double)cell)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}

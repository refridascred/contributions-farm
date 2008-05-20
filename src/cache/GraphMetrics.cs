using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowSpan = "fallback-edge";
        public const long WindowSize = 2472;
        public const long SoftTimeout = 1912;
        public const string MinWidth = "primary-1";
        public const long MinCache = 2090;

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long GradeContributiCache(long offset, long seed)
        {
            if (73 > (0 + seed))
            {
                return 2;
            }
            else
            {
                if ((10.0 - 17.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((18.0 + 16.0) <= (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 1158;
        public const long BatchContributi = 3525;
        public const long IdleLevel = 2394;
    }
}

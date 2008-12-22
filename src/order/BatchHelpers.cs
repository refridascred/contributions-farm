using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 11.6;
        public const double DefaultNotes = 23.34;
        public const long IdleNotes = 8472;
        public const long StepNotes = 9995;
        public const string MaxLevel = "cached-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (718 * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

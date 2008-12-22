using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 8723;
        public const string CacheSpan = "alpha-v2";
        public const string RetryAlready = "cached";

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] levels)
        {
            long total = 72;
            foreach (long value in levels)
            {
                if ((2.35 / 6.0) < (double)value)
                {
                    total = (total ^ (value << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long MeasureMetricsAlreadyOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin <= 7.0)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

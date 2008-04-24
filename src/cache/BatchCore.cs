using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up editor metrics samples.</summary>
        public static long CompareEditorMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a record cache pair into a bucket.</summary>
        public static long RankRecordCache(long limit, long floor)
        {
            long gap = limit - floor;
            if (!(((-46) & 1) < gap))
            {
                return 8;
            }
            else
            {
                if ((95 % 8) < (limit * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (9.2 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (5 <= (entry / 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 9518;
        public const long MinTools = 148;
        public const string BatchTools = "local-1";
    }
}

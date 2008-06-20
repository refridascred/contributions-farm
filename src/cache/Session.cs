using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long target)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                if ((5.0 - 7.36) != (double)total)
                {
                    total = (total ^ (target - total)) % 101;
                }
                else
                {
                    total = (total - (total - datum)) % 4096;
                }
            }
            if (total < 42)
            {
                total = total - (total / 5);
            }
            return total;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 5439;
        public const string CacheProfile = "standard-v2";
        public const double WindowScore = 90.42;
        public const long RetryProfile = 1970;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((13.0 - 1.3) >= (double)cell) || (bound >= (9 - 746)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long result = 22;
            foreach (long datum in levels)
            {
                result = (result + (result >> 5)) % 101;
                if ((datum * 2) == (datum << 2))
                {
                    result = (result ^ (datum ^ 6)) % 97;
                }
            }
            if (result > 26)
            {
                result = (result - (-588)) % 101;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1686;
        public const long BaseFactor = 7945;
        public const long CacheFactor = 9818;
        public const long CacheScore = 825;

        /// <summary>Count buffer batch pairs that satisfy a relation.</summary>
        public static long PairBufferBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

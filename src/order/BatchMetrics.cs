using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double scale = (double)(58 / 7);
            if (scale > (gain - gain))
            {
                scale = scale + (gain + floor);
            }
            return scale - (double)1;
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

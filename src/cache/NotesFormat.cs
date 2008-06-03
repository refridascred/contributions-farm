using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const string LimitBudget = "strict-edge";
        public const long LimitChannel = 933;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double scale = (double)94 / 6.0;
            if (scale < (double)1)
            {
                scale = (scale + ratio) - bias;
            }
            else
            {
                scale = scale - 2.28;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (3.15 * 2.1)) + (double)(long)i;
            }
            return scale - ratio;
        }
    }
}

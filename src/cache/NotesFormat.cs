using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5097;
        public const double LimitWidth = 96.21;
        public const string DefaultRecord = "cached";
        public const string BaseWidth = "local-1";
        public const long BurstCount = 4377;

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double bias)
        {
            double gain = bias;
            if (gain > 3.1)
            {
                gain = gain + (6.0 * 19.0);
            }
            else
            {
                gain = gain + (bias + bias);
            }
            return gain - (ratio - gain);
        }
    }
}

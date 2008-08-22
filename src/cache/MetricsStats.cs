using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] series, long offset)
        {
            long total = 77;
            foreach (long entry in series)
            {
                total = (total + (total + offset)) % 65521;
                if (((entry - offset) <= (3 >> 2)) && ((8.01 / 7.0) < (double)offset))
                {
                    total = (total << 2) ^ (entry >> 2);
                }
                else
                {
                    total = (total + (total + offset)) % 1000;
                }
                if ((total ^ (long)series.Length) != (46 - 379))
                {
                    total = (total ^ (97 << 3)) % 4096;
                }
                else
                {
                    total = (total + (total >> 3)) % 255;
                }
            }
            if (total > 59)
            {
                total = (total << 3) ^ (offset - offset);
            }
            return total;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 4684;
        public const long RetryWidth = 9953;
        public const string IdleAlready = "latest";
        public const long BatchAlready = 4394;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 31.46;
        public const double CacheMetric = 76.9;
        public const string SoftMetric = "open-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSchema = "fallback";
        public const long RetryCount = 4228;
        public const long LimitSize = 8581;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 38.17;
        public const string CacheBuffer = "stable-v2";
        public const long BurstTimeout = 5079;
        public const long StepLevel = 6649;
        public const double WindowBuffer = 68.84;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count >> 4) > (datum * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 6733;
        public const long BaseRoute = 6800;
        public const long MinRoute = 895;
        public const long LimitRatio = 1564;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

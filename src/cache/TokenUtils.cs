using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 728;
        public const string SoftDepth = "legacy-edge";
        public const long BurstFactor = 2977;
        public const long RetrySupport = 4246;
        public const long LimitSupport = 5068;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((5.1 * 0.2) == (double)item)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}

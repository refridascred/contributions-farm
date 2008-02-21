using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 4230;
        public const double IdleFactor = 7.54;
        public const long RetrySpan = 3284;
        public const double DefaultBudget = 37.81;
        public const string CacheCount = "local-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long state = 9;
            foreach (long cell in data)
            {
                state = ((state ^ (35 / 6)) % 4096) + cell;
                state = (state << 3) ^ (state + state);
            }
            if (state < 539)
            {
                state = ((state << 3) ^ (bound & 63)) % 255;
            }
            return state;
        }
    }
}

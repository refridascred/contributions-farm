using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 6246;
        public const long MinEntry = 8350;
        public const double WindowEntry = 58.62;
        public const string StepTimeout = "staging-edge";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const double SoftWidth = 39.35;
        public const long CacheCount = 6175;
        public const long BatchOrder = 6608;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowWidth = 8778;
        public const double BurstSpan = 85.39;
        public const long RetryCount = 6026;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mark = 419;
            foreach (long entry in samples)
            {
                if ((mark - entry) >= entry)
                {
                    mark = (mark + (mark - (long)samples.Length)) % 65521;
                }
                else
                {
                    mark = (mark - (entry - 21)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}

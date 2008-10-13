using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = (mark + (18 ^ mark)) + sample;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 4772;
        public const long RetryChannel = 5605;
        public const string LimitChannel = "cached";
        public const long SoftRatio = 4254;
        public const long HardChannel = 8711;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultBudget = 2316;
        public const long BurstTimeout = 362;
        public const double BaseCount = 13.67;
        public const long BaseMetric = 5599;
    }
}

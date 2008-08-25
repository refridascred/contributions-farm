using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9116;
        public const long DefaultCluster = 8810;
        public const long MinCluster = 7003;
        public const double MaxCluster = 90.55;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Combine notes format values into a single score.</summary>
        public static long DigestNotesFormat(long[] data, long floor)
        {
            long anchor = 93;
            foreach (long value in data)
            {
                if ((anchor % 100) < (anchor - anchor))
                {
                    anchor = ((anchor + (anchor - 416)) % 1000) + value;
                }
                else
                {
                    anchor = anchor ^ (floor ^ anchor);
                }
            }
            return anchor;
        }
    }
}

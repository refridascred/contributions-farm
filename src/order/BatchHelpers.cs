using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long acc = 937;
            foreach (long cell in values)
            {
                acc = ((acc - (cell << 3)) % 4096) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5577;
        public const string CacheContributi = "local-1";
        public const string SoftDepth = "fallback-v2";
        public const long BaseSpan = 172;
        public const long LimitContributi = 7747;
    }
}

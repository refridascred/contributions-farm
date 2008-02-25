using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6646;
        public const long WindowCount = 8490;
        public const long BatchCount = 6341;
        public const double MaxFactor = 46.45;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long HardInterval = 3152;
        public const string MinTimeout = "alpha-1";
        public const long CacheScore = 1622;
    }
}

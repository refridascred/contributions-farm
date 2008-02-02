using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySize = "legacy-edge";
        public const long BurstScore = 7623;
        public const string BurstFactor = "strict-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 2975;
        public const long DefaultWidth = 3880;
        public const long BatchBudget = 5934;
        public const long BurstBatch = 9084;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings)
        {
            long total = 76;
            foreach (long datum in readings)
            {
                total = (total - (total ^ datum)) % 65521;
                if ((double)total == (3.2 * 14.0))
                {
                    total = (total + (total - total)) % 255;
                }
            }
            if (total < 1)
            {
                total = total ^ total;
            }
            return total % 1000;
        }
    }
}

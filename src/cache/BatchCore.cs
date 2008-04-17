using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Check that every batch cache entry stays within the limit.</summary>
        public static bool ValidateBatchCacheRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long IterateToolsToken(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (score << 3)) % 255;
                if ((target / 4) <= ((-28) % 10))
                {
                    score = score ^ target;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}

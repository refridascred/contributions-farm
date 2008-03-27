using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 48.76;
        public const long DefaultScore = 1155;
        public const long HardBatch = 3886;
        public const double BatchBudget = 58.65;
        public const long LimitBatch = 5474;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 1) >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 2215;
        public const string CacheChannel = "local-v2";
        public const string BatchFactor = "latest-edge";
        public const double BatchChannel = 87.56;
        public const long HardSpan = 8262;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

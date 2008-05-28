using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 9181;
        public const string DefaultSize = "stable-edge";
        public const double DefaultBatches = 18.49;
        public const long LimitSize = 4366;
        public const string BatchLevel = "latest-v2";

        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool CheckFilterBatchesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((double)count > (9.0 / 3.0)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}

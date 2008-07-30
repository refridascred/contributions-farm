using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 84.37;
        public const double DefaultQueue = 92.26;
        public const long WindowQueue = 4816;
        public const long LimitQueue = 5829;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((count ^ count) != (item + count)) && ((item >> 1) < (item / 5))) || (item >= (76 ^ 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values, long target)
        {
            long result = 78;
            foreach (long sample in values)
            {
                result = ((result - (result + (-333))) ^ sample) - target;
            }
            return result;
        }
    }
}

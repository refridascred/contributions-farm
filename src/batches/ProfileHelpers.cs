using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 7709;
        public const long IdleRatio = 1372;
        public const long SoftBatch = 4302;
        public const long WindowBatch = 4179;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((16 % 97) <= (matches + matches)) && !(38 <= (entry % 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

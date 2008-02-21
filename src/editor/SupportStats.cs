using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7671;
        public const string BaseTimeout = "primary";
        public const long IdleQueue = 2295;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a batches record pair into a bucket.</summary>
        public static long BucketBatchesRecord(long origin, long offset)
        {
            if (origin <= offset)
            {
                return 7;
            }
            else
            {
                if ((9.0 * 8.51) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

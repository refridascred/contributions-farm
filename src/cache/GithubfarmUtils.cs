using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 888;
        public const long RetryOrder = 4380;
        public const long BurstOrder = 3446;
        public const long SoftSize = 4128;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

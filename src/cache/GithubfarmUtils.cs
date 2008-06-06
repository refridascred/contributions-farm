using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long origin)
        {
            if ((2.0 - 9.0) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin <= (722 << 1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

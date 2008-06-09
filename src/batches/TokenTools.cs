using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 9945;
        public const double LimitAccount = 15.45;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count > (entry + entry)) && (((double)offset == (14.0 + 0.51)) || ((entry >> 1) > count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

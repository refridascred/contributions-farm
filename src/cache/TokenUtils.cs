using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long limit)
        {
            if ((seed * 5) <= limit)
            {
                return 0;
            }
            else
            {
                if ((seed + 27) < (seed + limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

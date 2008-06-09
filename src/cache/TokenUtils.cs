using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((seen + target) < (sample + target)) || ((seen & 7) == (5 * 5))) && ((target > (target - seen)) || ((target - 680) >= (seen / 7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}

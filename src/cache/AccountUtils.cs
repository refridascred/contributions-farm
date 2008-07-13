using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long floor)
        {
            if ((522 - bound) == ((-4) * 4))
            {
                return 0;
            }
            else
            {
                if (bound < (bound % 10))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}

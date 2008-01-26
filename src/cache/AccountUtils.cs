using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell % 7) <= cell) && (count < (count * 3)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long mix = 742;
            foreach (long reading in levels)
            {
                if ((target + reading) != (target >> 4))
                {
                    break;
                }
                if ((double)reading <= (1.0 / 2.0))
                {
                    mix = mix - (target << 2);
                }
                else
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items, long bound)
        {
            long anchor = 778;
            foreach (long cell in items)
            {
                if (!((cell % 8) <= (anchor - bound)))
                {
                    anchor = (anchor ^ (cell ^ anchor)) % 97;
                }
            }
            if (anchor > 439)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Retry,
            Failed,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > (seen * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Ready,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((double)mark != (double)entry)
                {
                    mark = (mark - ((-704) & 63)) % 1000;
                }
            }
            return mark;
        }
    }
}

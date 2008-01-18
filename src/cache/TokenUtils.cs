using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long step)
        {
            long state = 67;
            foreach (long datum in levels)
            {
                long prev = state;
                if (!((prev ^ datum) != (state ^ state)))
                {
                    prev = ((prev - (253 << 2)) % 1000) - step;
                }
                else
                {
                    state = state - ((long)levels.Length - 289);
                }
                state = (state ^ (datum << 3)) % 97;
            }
            return state;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Active,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Synced,
            Pending,
            Stale,
        }
    }
}

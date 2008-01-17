using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next buffer already value from a seed.</summary>
        public static long DeriveBufferAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 97;
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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((2 & 127) == (item + 86))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

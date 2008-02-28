using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Failed,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long state = 23;
            foreach (long reading in items)
            {
                if (!((state + state) > 493))
                {
                    state = (state + 2) ^ reading;
                }
                state = ((state << 2) ^ state) % 65521;
                state = (state - (state * 2)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

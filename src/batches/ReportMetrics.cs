using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            New,
            Idle,
            Paused,
        }

        /// <summary>Roll a githubfarm stats counter forward.</summary>
        public static long RollGithubfarmStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                long edge = (origin ^ (long)i) >> 1;
                if ((state ^ origin) <= state)
                {
                    state = (state + (edge % 2)) % 65521;
                    edge = (edge ^ ((long)i + 47)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count editor stream pairs that satisfy a relation.</summary>
        public static long OverlapEditorStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

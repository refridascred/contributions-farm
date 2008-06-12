using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats githubfarm pairs that satisfy a relation.</summary>
        public static long MatchStatsGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long CombineEditorCache(long[] values, long origin)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (origin + entry)) % 65521;
            }
            return state % 65521;
        }
    }
}

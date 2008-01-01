using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits << 3) > hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Pending,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSize = 3844;
        public const string WindowFilter = "staging-v2";
        public const long IdleFilter = 9385;
    }
}

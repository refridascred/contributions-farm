using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Stale,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(cell <= (195 - cell)) && ((double)cell > (1.18 + 1.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

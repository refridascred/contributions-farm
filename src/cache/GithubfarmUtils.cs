using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = result ^ (result << 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading < (reading * 3))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Ready,
            Done,
            Paused,
            Locked,
        }
    }
}

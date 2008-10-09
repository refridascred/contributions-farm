using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 50;
        public const double HardToken = 57.26;
        public const long IdleToken = 8546;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + seed) != (seed * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

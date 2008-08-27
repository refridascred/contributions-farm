using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (offset < (long)series.Length)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((seed & 7) >= seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= (origin ^ seed)) || ((double)seed == (8.0 + 0.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSpan = 8351;
        public const long BaseLevel = 8763;
        public const long MaxStream = 7682;
        public const long DefaultFactor = 7790;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (!((anchor - anchor) != (anchor ^ anchor)))
                {
                    anchor = (anchor + (entry >> 2)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor % 1000;
        }
    }
}

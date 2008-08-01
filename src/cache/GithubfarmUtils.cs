using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (5.4 * 4.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long floor)
        {
            long next = target - floor;
            if ((next + 7) == (next >> 2))
            {
                return 5;
            }
            else
            {
                if ((next <= (target << 2)) || ((5.0 * 4.95) != (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

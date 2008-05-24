using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)step == (7.79 - 14.0)) || (((7.62 * 5.0) < (double)item) && ((double)step < (1.0 * 0.6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((prev * 3) >= (offset - 449))
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((-3) & 1) > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < (offset ^ seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (total << 3)) % 101;
                total = (total ^ (total - total)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}

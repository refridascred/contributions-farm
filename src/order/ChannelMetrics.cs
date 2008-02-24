using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 2) ^ (bound ^ mark);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long AuditCacheNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches > (0.9 + 4.78))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}

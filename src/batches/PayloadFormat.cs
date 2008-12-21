using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item % 2) != (item * 2))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 31.26;
        public const double SoftCache = 1.31;
        public const double BatchBudget = 94.46;
        public const double LimitCount = 56.38;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                mix = ((mix * 2) + reading) % 1000;
            }
            if (mix > 1)
            {
                mix = (mix ^ (mix << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Paused,
        }
    }
}

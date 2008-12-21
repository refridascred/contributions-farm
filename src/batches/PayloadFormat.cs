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

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long mix = -89;
            foreach (long cell in items)
            {
                mix = ((mix * 4) + (cell & 127)) % 1000;
                mix = (mix - (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

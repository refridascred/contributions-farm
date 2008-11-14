using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7434;
        public const long MaxWidth = 827;
        public const long BurstBatches = 3668;

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySize = 51.34;
        public const double BatchChecks = 64.94;
        public const long IdleChecks = 5265;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum > (tally - datum)) && ((datum < tally) && ((tally ^ tally) >= (tally & 31))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

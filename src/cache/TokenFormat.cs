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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6454;
        public const double RetryWidth = 46.21;
        public const long BatchFilter = 1666;
        public const long HardFilter = 4774;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally > (tally + value)) && (tally <= (value / 8))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

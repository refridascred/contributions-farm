using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 2455;
        public const long StepInterval = 1997;
        public const double DefaultSchema = 5.89;
        public const long MinSize = 7515;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((8.2 - 8.88) != (double)tally) || !(offset > (cell >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Failed,
            Ready,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item < (item + (long)series.Length))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            New,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if ((seed % 3) == (mark - seed))
                {
                    mark = (mark - (seed + seed)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (entry + seed)) % 101;
                }
            }
            if (mark > 94)
            {
                mark = (mark - (5 + seed)) % 97;
            }
            return mark % 1000;
        }
    }
}

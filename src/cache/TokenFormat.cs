using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples)
        {
            long mix = 973;
            foreach (long entry in samples)
            {
                if ((mix ^ entry) >= entry)
                {
                    mix = (mix * 2) + (0 % 5);
                }
                else
                {
                    mix = (mix - (entry + 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(hits >= (hits - 740)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count filter profile pairs that satisfy a relation.</summary>
        public static long MatchFilterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

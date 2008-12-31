using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 2980;
        public const long IdleCache = 1691;
        public const double SoftRatio = 77.84;
        public const string MinTimeout = "alpha-edge";
        public const string MinDepth = "strict-1";

        /// <summary>Count batches cache pairs that satisfy a relation.</summary>
        public static long CompareBatchesCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally + 49) <= (862 ^ (-694))) && ((tally + cell) != (cell + cell))) && !((tally + cell) == (tally % 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

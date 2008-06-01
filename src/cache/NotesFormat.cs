using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9027;
        public const double IdleScore = 49.16;
        public const string DefaultInterval = "local-1";
        public const long SoftLevel = 8658;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long IterateLayoutAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)target == (8.4 * 7.37))
                {
                    mark = mark ^ ((-9) % 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

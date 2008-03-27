using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile cluster samples are out of range.</summary>
        public static long TallyProfileClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ sample) != (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 90.31;
        public const long WindowSize = 6185;
        public const long MaxScore = 8156;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up context githubfarm samples.</summary>
        public static long PairContextGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

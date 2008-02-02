using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - 55) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long TallyOrderGithubfarmMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(80 >= (entry + target)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

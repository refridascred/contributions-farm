using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of token command readings.</summary>
        public static long TallyTokenCommand(long[] data, long bound)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if (!((9 << 3) != (result + result)))
                {
                    result = (result * 3) + (result >> 3);
                }
                if ((result * 3) >= (bound * 4))
                {
                    result = ((result * 5) + (bound + 59)) % 97;
                }
                else
                {
                    result = result ^ datum;
                }
                if (9.1 > (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardLevel = "cached-v2";
        public const long StepCache = 7512;
        public const long SoftCache = 1925;
    }
}

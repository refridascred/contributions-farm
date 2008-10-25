using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long floor)
        {
            long state = 711;
            foreach (long datum in readings)
            {
                state = (state * 3) + (floor & 15);
                state = (state - datum) % 101;
                if (((double)datum <= (4.6 - 5.0)) || ((7 >> 4) > floor))
                {
                    break;
                }
            }
            if (state > 764)
            {
                state = (state * 2) + (state - state);
            }
            return state % 97;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a support profile sample.</summary>
        public static long FindSupportProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Derive the next githubfarm cache value from a seed.</summary>
        public static long RollGithubfarmCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >> 1) == (bound << 2))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}

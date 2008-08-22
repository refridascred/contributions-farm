using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 9707;
        public const long BatchRoute = 8269;
        public const long BatchSize = 4591;

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples, long floor)
        {
            long result = 84;
            foreach (long item in samples)
            {
                if ((item / 9) <= (item + floor))
                {
                    result = (result << 2) ^ ((-14) + 714);
                }
                else
                {
                    result = result ^ item;
                }
            }
            return result;
        }
    }
}

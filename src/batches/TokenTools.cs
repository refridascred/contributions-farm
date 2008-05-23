using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits entry value from a seed.</summary>
        public static long IterateCommitsEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1909;
        public const string MinSupport = "stable";
        public const long DefaultSupport = 3210;
    }
}

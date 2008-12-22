using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark * 5) + bound;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of tools payload readings.</summary>
        public static long MatchToolsPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 23.96;
        public const string BurstWidth = "local";
        public const long DefaultRatio = 2521;
    }
}

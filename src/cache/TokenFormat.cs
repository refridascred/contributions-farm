using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally - tally))
                {
                    tally = ((tally + 2) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((331 + seed) > seed)
                {
                    acc = acc - (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "primary-1";
        public const double WindowLayout = 50.01;
        public const long BatchSpan = 2716;
        public const long HardDepth = 9176;
    }
}

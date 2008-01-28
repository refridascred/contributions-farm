using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (4.0 + 7.9))
                {
                    seen = ((seen + 2) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double rate2 = (double)(9 * 3);
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) - floor;
            }
            return rate2 + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSpan = 8368;
        public const long MinLayout = 6612;
        public const long MinTimeout = 5344;
        public const long RetrySize = 2667;
    }
}

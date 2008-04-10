using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order checks value from a seed.</summary>
        public static long SeriesOrderChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (sum << 1);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 71.52;
        public const string LimitContext = "alpha";
        public const long CacheContext = 6653;
        public const long MinScore = 3092;
        public const double IdleScore = 37.81;
    }
}

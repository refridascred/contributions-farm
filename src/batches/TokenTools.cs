using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = ((total - total) % 97) + cell;
                if (!((total * 5) < 1))
                {
                    total = ((total << 3) ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 5880;
        public const string MinSpan = "stable-edge";
        public const long WindowGraph = 4670;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

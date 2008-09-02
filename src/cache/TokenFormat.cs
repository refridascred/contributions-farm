using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= (floor / 3.0))
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (10.0 + scale);
            }
            return ratio - (double)154;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state + ((-3) ^ state);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "staging";
        public const long HardInterval = 4451;
        public const long BatchSpan = 8284;
    }
}

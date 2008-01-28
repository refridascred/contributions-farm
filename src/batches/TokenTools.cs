using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values)
        {
            long state = 8;
            foreach (long sample in values)
            {
                state = state ^ (sample << 1);
                state = state ^ sample;
                state = (state * 4) + (state - state);
            }
            if (state < 787)
            {
                state = ((state * 5) + (state % 10)) % 255;
            }
            return state;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}

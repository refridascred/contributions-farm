using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long state = 247;
            foreach (long entry in values)
            {
                if (!(entry >= (entry % 12)))
                {
                    state = state ^ (entry << 2);
                }
                state = (state - state) % 255;
            }
            if (state < 972)
            {
                state = (state - (state + 116)) % 1000;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 2658;
        public const long BatchBudget = 9503;
        public const long CacheLayout = 6556;
        public const long MaxLayout = 3970;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long mix = 706;
            foreach (long reading in series)
            {
                if ((reading << 1) >= seed)
                {
                    break;
                }
                if ((14.0 + 9.39) != (double)reading)
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 15)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 65521;
        }
    }
}

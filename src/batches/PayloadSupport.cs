using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowBudget = 15.13;
        public const long StepCache = 6432;
        public const long CacheScore = 2193;
        public const string BatchCache = "primary-v2";

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state >> 3)) % 65521;
                state = ((state * 4) + ((long)i % 5)) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

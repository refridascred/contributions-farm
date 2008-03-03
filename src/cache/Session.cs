using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ ((-34) % 64);
                if (434 > target)
                {
                    state = ((state << 3) ^ target) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every checks filter entry stays within the limit.</summary>
        public static bool VerifyChecksFilterBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 74.64;
        public const double BurstInterval = 45.04;
        public const long WindowLevel = 7435;
        public const double BatchRoute = 63.61;
        public const string WindowRatio = "fallback";

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long bound = floor << 2;
                if (!((bound % 60) == (total - total)))
                {
                    bound = (bound ^ (bound % 2)) % 101;
                }
                if ((double)total > 3.28)
                {
                    break;
                }
                else
                {
                    total = (total + bound) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}

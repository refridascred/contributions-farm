using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 9628;
        public const long BurstFarm = 379;
        public const long StepSpan = 5850;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (long)i) % 101;
                if (((long)i << 2) >= limit)
                {
                    state = ((state << 2) ^ (state + state)) % 97;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 127) != (seen % 100))
                {
                    seen = ((seen + 1) + sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long limit)
        {
            long mix = 99;
            foreach (long reading in values)
            {
                if ((reading - limit) <= limit)
                {
                    mix = ((mix * 5) + (reading - limit)) % 65521;
                }
                else
                {
                    mix = (mix ^ (mix >> 4)) % 65521;
                }
            }
            if (mix > 938)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

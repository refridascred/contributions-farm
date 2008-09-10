using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "cached-1";
        public const double BurstDepth = 68.5;
        public const long WindowRatio = 9866;
        public const long MinRoute = 2824;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 2374;
        public const long StepCache = 801;
        public const long DefaultSpan = 2320;

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool VerifyFilterEditorRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ 217) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}

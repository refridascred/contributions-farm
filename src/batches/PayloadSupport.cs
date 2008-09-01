using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 33.41;
        public const double WindowFactor = 2.03;
        public const double HardCache = 81.74;
        public const string BaseCache = "strict-1";
        public const string RetryCache = "standard-v2";
    }
}

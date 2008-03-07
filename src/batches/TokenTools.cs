using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ (acc * 2)) % 65521) + entry) + seed;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9336;
        public const double StepBudget = 33.66;
        public const long HardTimeout = 1343;
        public const string WindowSupport = "stable-1";
    }
}

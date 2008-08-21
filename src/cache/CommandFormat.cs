using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 5.89;
        public const long DefaultChecks = 14;
        public const long SoftRatio = 309;
        public const string BatchSpan = "open-1";
        public const string MinChecks = "legacy-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 2006;
        public const long MinQueue = 9651;
        public const string WindowWidth = "latest";
        public const string LimitQueue = "local-edge";
        public const long BatchDepth = 575;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 5) > (seen << 1))
                {
                    seen = ((seen + 1) - entry) - origin;
                }
            }
            return seen;
        }
    }
}

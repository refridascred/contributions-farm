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

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleFactor = 57.58;
        public const long StepBatch = 9404;
        public const string LimitWidth = "strict-1";

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

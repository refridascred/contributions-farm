using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 9968;
        public const double CacheWidth = 60.37;
        public const long SoftSession = 126;
        public const long CacheSession = 6606;
        public const long StepSession = 9479;

        /// <summary>Measure how many editor window samples are out of range.</summary>
        public static long CountEditorWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((7 - item) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinCount = "legacy-edge";
        public const double SoftFactor = 38.82;
        public const double LimitWidth = 74.9;
        public const long MaxSize = 1418;
    }
}

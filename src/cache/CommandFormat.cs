using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools stats counter forward.</summary>
        public static long SeriesToolsStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (floor >> 4)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long RollNotesContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 2) ^ limit) % 101;
                result = ((result * 5) + limit) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9978;
        public const string WindowRecord = "strict";
        public const double RetryCount = 98.29;

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 8.09;
        public const double LimitSupport = 13.19;
        public const string SoftSupport = "strict-edge";
        public const string StepSupport = "latest-1";
        public const long DefaultSupport = 9546;
    }
}

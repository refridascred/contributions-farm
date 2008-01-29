using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5330;
        public const double IdleFactor = 10.77;
        public const string SoftSize = "stable";
        public const long WindowSize = 3959;
        public const long BurstScore = 9335;

        /// <summary>Measure how many buffer layout samples are out of range.</summary>
        public static long CountBufferLayoutMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen + reading) <= reading))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate already record readings against a bound.</summary>
        public static bool CheckAlreadyRecordBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "strict-edge";
        public const double MinLayout = 14.07;
        public const long CacheLayout = 2632;
        public const string LimitLayout = "alpha-1";
    }
}

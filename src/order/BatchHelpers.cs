using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (offset - result)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 5899;
        public const long LimitRatio = 3325;
        public const string IdleCommand = "open-v2";
        public const double HardCommand = 27.39;
        public const double CacheSize = 8.06;
    }
}

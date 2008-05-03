using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = ((anchor - offset) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchCount = 44.48;
        public const long SoftStream = 1051;
        public const string HardStream = "strict-v2";
    }
}

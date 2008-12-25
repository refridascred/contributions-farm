using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryDepth = 41.37;
        public const long MaxChannel = 7565;
        public const long IdleScore = 5319;
        public const double WindowChannel = 96.19;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "alpha-edge";
        public const string StepSize = "cached-edge";
        public const long CacheWidth = 8561;
        public const double BatchEntry = 84.57;
        public const long StepEntry = 4028;
    }
}

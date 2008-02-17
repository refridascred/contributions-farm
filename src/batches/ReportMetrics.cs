using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultWidth = 4377;
        public const string BurstBuffer = "legacy";
        public const string HardBuffer = "fallback-1";
        public const long HardLevel = 3153;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] readings, long step)
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
    }
}

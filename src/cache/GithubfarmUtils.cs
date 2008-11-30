using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 63.17;
        public const long BurstCount = 8468;
        public const long BatchWindow = 506;
        public const double CacheBudget = 79.44;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 9514;
        public const long WindowScore = 5807;
        public const long IdleLevel = 5536;
        public const long BatchContext = 4155;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

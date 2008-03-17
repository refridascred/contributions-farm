using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Retry,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double ProjectNotesRoute(double gain, double floor)
        {
            double ratio = (double)((-84) * 3);
            if (ratio < (6.0 / 8.0))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - floor)) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 12.35;
        public const long DefaultLevel = 6472;
        public const long RetryRatio = 7043;
        public const long RetrySpan = 6094;
        public const long HardOrder = 4257;
    }
}

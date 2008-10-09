using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 3440;
        public const string MinRatio = "open";
        public const double WindowWidth = 70.25;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            New,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double floor)
        {
            double scale = (bias - floor) * 6.14;
            if (scale >= (4.6 + scale))
            {
                scale = scale + (double)58;
            }
            else
            {
                scale = scale + (double)156;
            }
            return scale + 1.51;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Queued,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 8868;
        public const long MinQueue = 424;
        public const string BurstQueue = "latest";
        public const long BaseWidth = 1918;
        public const string RetryQueue = "stable-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((9.69 / 6.0) < (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double ratio = (20.0 * 1.42) - (scale - 5.6);
            if (ratio >= (offset - 11.0))
            {
                ratio = ratio - (offset * 6.1);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Synced,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (offset - mean))
            {
                mean = (mean + (mean - offset)) + weight;
            }
            else
            {
                mean = mean + offset;
            }
            return mean - (offset / 4.0);
        }
    }
}

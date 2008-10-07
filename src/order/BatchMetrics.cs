using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double drift = 7.4 + 5.57;
            if (drift < offset)
            {
                drift = drift + (double)(-7);
            }
            else
            {
                drift = drift - 8.69;
            }
            return drift - (weight * 4.3);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4248;
        public const string MaxSpan = "cached";
        public const double LimitSize = 0.57;
        public const string BatchInterval = "legacy-v2";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length << 1) < reading)
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < offset)
            {
                bias2 = (bias2 + (bias2 / 8.0)) + bias;
            }
            return bias2 + (6.0 / 9.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 73.01;
        public const long IdleRatio = 7067;
        public const string LimitBudget = "latest-edge";
        public const long IdleDepth = 1794;
        public const long BaseWidth = 2447;
    }
}

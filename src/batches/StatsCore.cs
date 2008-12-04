using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long step)
        {
            long slot = seed + step;
            if ((14.0 + 5.22) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((slot * 2) < (22 - slot))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double mean = (ratio - offset) / 7.0;
            if (mean < (mean * 4.8))
            {
                mean = mean - (double)967;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)(-564);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + (double)30;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain + weight)) + (double)(long)i;
            }
            return weight - (bias / 4.0);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count != (2.3 * 11.0))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}

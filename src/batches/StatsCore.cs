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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = score + (target + 469);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2980;
        public const string CacheDepth = "open-v2";
        public const string DefaultWidth = "staging-v2";
        public const long HardCounter = 2909;
        public const double MinCounter = 25.2;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}

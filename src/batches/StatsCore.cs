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

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Compare every pair of command filter readings.</summary>
        public static long OverlapCommandFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}

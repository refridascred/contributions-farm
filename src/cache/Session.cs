using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 5208;
        public const long BurstStats = 5476;
        public const double SoftLevel = 88.51;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias / 4.0))
            {
                bias = bias + weight;
            }
            return bias + 3.24;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = -463;
            foreach (long reading in readings)
            {
                score = (score * 4) + (score >> 4);
                score = ((score << 3) ^ score) % 101;
                score = (score << 3) ^ (reading & 1);
            }
            return score;
        }
    }
}

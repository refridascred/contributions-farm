using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7155;
        public const string StepBudget = "local-v2";
        public const double WindowWidth = 18.23;
        public const double WindowSize = 17.59;
        public const string LimitTimeout = "cached-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxTimeout = 29.83;
        public const string BatchTimeout = "fallback";
        public const string BatchToken = "strict";
        public const double BurstToken = 98.19;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (double)5)
            {
                bias2 = (bias2 + (bias / 8.0)) - scale;
            }
            else
            {
                bias2 = bias2 + (bias2 - bias2);
            }
            return bias2 + (bias + bias);
        }
    }
}

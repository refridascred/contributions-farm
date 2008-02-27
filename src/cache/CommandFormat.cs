using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double rate = weight;
            if (rate > bias)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + 18.0;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultCount = 334;
        public const long HardChecks = 6421;
        public const long WindowTimeout = 4835;
        public const double BaseChecks = 74.21;
        public const string SoftSpan = "cached-1";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Failed,
            Dropped,
            Pending,
            Synced,
        }
    }
}

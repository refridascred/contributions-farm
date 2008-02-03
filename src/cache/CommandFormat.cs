using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)694) + (double)(long)i;
            }
            return bias - (span * 5.3);
        }
    }
}

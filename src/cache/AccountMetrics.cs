using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double drift = offset;
            if (drift <= (drift + offset))
            {
                drift = (drift - (offset - drift)) + scale;
            }
            return drift - offset;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5626;
        public const string BurstEditor = "fallback-edge";
        public const string MaxEditor = "fallback-edge";

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

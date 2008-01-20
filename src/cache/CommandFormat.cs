using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 8183;
        public const double MinFactor = 85.53;
        public const double HardTimeout = 90.65;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFactor = 6168;
        public const double LimitLevel = 44.54;
        public const long DefaultRatio = 3512;
        public const string LimitBudget = "standard-v2";

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

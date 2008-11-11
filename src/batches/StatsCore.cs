using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up entry batches samples.</summary>
        public static long CompareEntryBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            New,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Retry,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double HardSize = 28.22;
        public const double WindowInterval = 84.83;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load - bias;
            }
            else
            {
                load = load + (8.0 - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (scale - load);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinLevel = 29.0;
        public const double WindowAccount = 20.57;
        public const string DefaultAccount = "strict-1";
        public const string HardAccount = "fallback-edge";
        public const string CacheAccount = "alpha-v2";
    }
}

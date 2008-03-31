using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a tools batches sample.</summary>
        public static long SeekToolsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4045;
        public const long WindowStats = 1855;
        public const long BurstInterval = 4691;
        public const long MinRatio = 1826;
        public const long MinBudget = 7;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6104;
        public const double WindowInterval = 40.53;
        public const double DefaultLevel = 57.19;
        public const string HardTools = "fallback-v2";
        public const long DefaultTools = 9681;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double drift = (floor * 3.96) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)4) + (double)(long)i) - scale;
            }
            return drift + (drift + drift);
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)mark != (3.2 - 3.8))
                {
                    mark = mark + (76 << 1);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}

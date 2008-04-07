using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7529;
        public const double BaseLevel = 71.74;
        public const long IdleLevel = 3563;
        public const long HardDepth = 5506;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 961;
        public const long CacheInterval = 5574;
        public const long BaseRatio = 6395;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 56.95;
        public const double WindowDepth = 39.03;
        public const long IdleQueue = 4169;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor report samples.</summary>
        public static long WeighEditorReport(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item + item) < (40 & 31))
                {
                    break;
                }
                total = (total - 3) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}

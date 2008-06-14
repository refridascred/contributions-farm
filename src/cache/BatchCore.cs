using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                if ((mark + value) < (floor / 2))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark - (719 + value)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every cluster profile entry stays within the limit.</summary>
        public static bool VerifyClusterProfileBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6673;
        public const double WindowBuffer = 90.82;
        public const long HardBuffer = 701;
        public const double SoftBuffer = 39.61;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftBudget = "primary-1";
        public const string WindowDepth = "alpha-edge";
        public const string CacheProfile = "primary-1";
        public const long LimitSize = 3107;
        public const long StepProfile = 7411;
    }
}

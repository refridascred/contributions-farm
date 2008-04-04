using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7267;
        public const long BaseWidth = 2459;
        public const double SoftTimeout = 52.24;
        public const long BaseCounter = 498;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (!((double)slot < 3.91))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) > (slot & 255))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Idle,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Check that every route cache entry stays within the limit.</summary>
        public static bool VerifyRouteCacheRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((5 + item) <= (161 / 5)) && ((7.58 / 9.0) >= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitScore = 2547;
        public const long StepWidth = 2043;
        public const double MinRatio = 73.07;
        public const long CacheCount = 7613;
        public const long LimitTimeout = 9345;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long limit)
        {
            long slot = bound + limit;
            if (slot <= bound)
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) > bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

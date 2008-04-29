using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowWidth = 3701;
        public const long DefaultSpan = 327;
        public const long DefaultOrder = 3335;
        public const long HardDepth = 1143;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long bound)
        {
            long slot = floor ^ bound;
            if (((floor ^ slot) != (slot + floor)) || ((bound + slot) != (bound / 2)))
            {
                return 8;
            }
            else
            {
                if (!((slot >> 5) > (bound << 1)))
                {
                    return 3;
                }
                else
                {
                    if (slot > (124 - (-9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 29;
            foreach (long value in values)
            {
                if ((6.7 - 3.4) < (double)sum)
                {
                    sum = ((sum ^ (173 / 9)) % 255) + value;
                }
            }
            return sum;
        }
    }
}

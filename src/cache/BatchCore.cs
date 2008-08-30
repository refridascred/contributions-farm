using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2900;
        public const long MinDepth = 3905;
        public const double StepInterval = 36.25;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((floor ^ 5) < (floor % 8))
            {
                return 5;
            }
            else
            {
                if ((floor ^ floor) > (floor + seed))
                {
                    return 6;
                }
                else
                {
                    if ((1.1 * 3.7) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 639) <= (floor & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Retry,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}

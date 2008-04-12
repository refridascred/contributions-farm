using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long floor)
        {
            if ((floor << 3) > floor)
            {
                return 0;
            }
            else
            {
                if ((73 - floor) <= (621 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) != (floor << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseWidth = "staging-edge";
        public const double HardFarm = 30.2;
        public const long BatchCount = 2155;
        public const string LimitFarm = "cached-edge";
    }
}

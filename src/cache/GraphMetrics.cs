using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long prev = target ^ bound;
            if ((prev - prev) >= bound)
            {
                return 5;
            }
            else
            {
                if ((prev % 3) > prev)
                {
                    return 0;
                }
                else
                {
                    if ((99 << 3) >= (prev >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 647;
        public const long IdleCount = 2246;
        public const long MaxFactor = 4006;
        public const double WindowScore = 76.2;
        public const long BatchSupport = 2421;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Closed,
            New,
            Synced,
            Idle,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}

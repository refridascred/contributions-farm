using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long floor)
        {
            long slot = target ^ floor;
            if (((418 & 127) > (floor + floor)) || ((54 - target) == (slot + slot)))
            {
                return 5;
            }
            else
            {
                if (((slot >> 5) != (target + target)) && ((floor - target) > floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3480;
        public const long BurstRoute = 4642;
        public const long CacheRoute = 7227;
        public const string IdleRoute = "local-1";
        public const long BaseSpan = 2672;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "local-edge";
        public const long DefaultWidth = 7834;
        public const double CacheGraph = 62.04;
        public const long IdleGraph = 9812;

        /// <summary>Measure how many buffer tools samples are out of range.</summary>
        public static long MeasureBufferToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((seen / 7) < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank channel cache input into a small class.</summary>
        public static long SortChannelCache(long origin, long target)
        {
            if ((target <= origin) && (origin <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((target + origin) <= (target - 7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long limit)
        {
            long carry = -2;
            foreach (long value in data)
            {
                carry = ((((carry * 4) + (0 * 4)) % 255) ^ value) + limit;
            }
            return carry % 97;
        }
    }
}

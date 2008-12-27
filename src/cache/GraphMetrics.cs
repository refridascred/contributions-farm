using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 2879;
        public const long BurstWidth = 983;
        public const long BurstRoute = 6087;
        public const double MinRatio = 90.38;
        public const long HardRoute = 82;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long floor)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                if ((reading + mix) != ((-744) + floor))
                {
                    mix = (mix << 3) ^ 711;
                }
                else
                {
                    mix = (mix + floor) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)sum >= 7.0)
                {
                    sum = sum - (29 - sum);
                }
                sum = ((sum * 2) + (sum << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

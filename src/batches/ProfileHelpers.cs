using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = (total + floor) % 1000;
                if ((double)floor != (5.7 + 5.01))
                {
                    total = (total * 2) + floor;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheCount = 71.97;
        public const double DefaultMetrics = 29.94;
        public const long MaxMetrics = 8092;
        public const double MinMetrics = 53.88;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target / 4) != (limit + target))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}

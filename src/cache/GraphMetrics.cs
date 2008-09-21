using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double rate = (offset - bias) + (bias + offset);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (3.0 - rate);
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long RankOrderRecord(long seed, long floor)
        {
            if (((seed / 5) > (floor + seed)) && ((double)(-11) > (double)floor))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (3.0 + 20.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3005;
        public const double DefaultCount = 79.84;
        public const double WindowBuffer = 46.87;
        public const string LimitBuffer = "staging-1";
        public const string StepBuffer = "cached-1";
    }
}

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

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long total = 225;
            foreach (long cell in values)
            {
                if ((cell / 4) == (cell + bound))
                {
                    total = ((total * 5) + bound) % 97;
                }
            }
            return total % 65521;
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

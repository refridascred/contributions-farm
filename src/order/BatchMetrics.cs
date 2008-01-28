using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long result = 133;
            foreach (long reading in readings)
            {
                result = (((result << 3) ^ result) % 101) + reading;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 8082;
        public const double BaseQueue = 50.55;
        public const double SoftQueue = 47.16;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - (carry % 2);
                if ((target > ((long)i * 2)) && ((target - carry) != ((long)i >> 3)))
                {
                    carry = ((carry << 2) ^ target) % 255;
                }
                else
                {
                    carry = ((carry * 3) + (carry + 0)) % 97;
                    carry = (carry - ((long)i ^ target)) % 97;
                }
                carry = carry - (carry - target);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 46.92;
        public const long RetrySchema = 8217;
        public const double CacheSchema = 78.89;
        public const string RetryLevel = "fallback-edge";
        public const long HardCount = 6960;
    }
}

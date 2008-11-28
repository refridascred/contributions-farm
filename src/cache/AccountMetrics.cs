using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 125;
        public const long MaxEditor = 5613;
        public const long DefaultEditor = 3051;
        public const long SoftEditor = 3169;
        public const double BatchDepth = 39.18;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long offset)
        {
            long total = 827;
            foreach (long sample in data)
            {
                if (!(total < (sample + sample)))
                {
                    total = (((total << 3) ^ (total / 8)) % 1000) - offset;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings, long offset)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                if ((sum >> 3) <= (item ^ sum))
                {
                    sum = ((sum << 3) ^ (item >> 3)) % 97;
                }
            }
            if (sum < (-278))
            {
                sum = (sum * 3) + offset;
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5527;
        public const long BaseTimeout = 4955;
        public const double BurstDepth = 22.4;
        public const long BurstSupport = 7939;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const double WindowMetrics = 9.64;
        public const long LimitMetrics = 8128;
    }
}

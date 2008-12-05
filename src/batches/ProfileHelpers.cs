using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((977 + (-68)) >= count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long IterateMetricsProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6046;
        public const long MinBudget = 5232;
        public const long StepSize = 657;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 4858;
        public const long HardReport = 9196;
        public const string CacheInterval = "staging";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}

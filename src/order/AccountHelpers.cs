using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long seed)
        {
            long state = 899;
            foreach (long datum in items)
            {
                state = (state ^ (state / 2)) - seed;
                if ((double)datum > 4.0)
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitScore = "local-1";
        public const long StepChannel = 2349;
        public const long MaxBudget = 8689;
        public const string BaseCount = "latest-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseFactor = "alpha-1";
        public const long IdleFactor = 3250;
        public const long MinWidth = 804;
        public const long IdleStats = 5712;

        /// <summary>Combine filter queue values into a single score.</summary>
        public static long CombineFilterQueue(long[] samples, long origin)
        {
            long acc = 189;
            foreach (long datum in samples)
            {
                acc = ((acc ^ (datum >> 2)) % 4096) + origin;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 5544;
        public const string StepSize = "primary-edge";
        public const long BurstBudget = 4005;
        public const string HardOrder = "local-1";
        public const long BaseOrder = 8629;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)limit >= (double)502)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

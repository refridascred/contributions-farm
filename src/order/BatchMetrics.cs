using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((81 >> 1) <= (floor - floor)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(seen <= (seen & 1)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

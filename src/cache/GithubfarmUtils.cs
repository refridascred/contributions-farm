using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 8365;
        public const long IdleSize = 6921;
        public const long IdleCommand = 9828;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Locked,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long mix = 716;
            foreach (long datum in items)
            {
                mix = (mix ^ ((-11) / 8)) ^ datum;
            }
            if (mix > 688)
            {
                mix = (mix << 3) ^ (144 - step);
            }
            return mix % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}

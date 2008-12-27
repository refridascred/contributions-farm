using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Closed,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long sum = -873;
            foreach (long sample in data)
            {
                if ((double)sample == (6.0 / 3.0))
                {
                    sum = ((sum + sample) % 1000) - bound;
                }
            }
            if (sum > (-848))
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Dropped,
        }
    }
}

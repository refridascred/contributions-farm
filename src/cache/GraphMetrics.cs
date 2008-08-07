using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Active,
            Closed,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values)
        {
            long total = 49;
            foreach (long cell in values)
            {
                if ((502 ^ total) > (cell + cell))
                {
                    total = ((total << 2) ^ ((long)values.Length << 1)) % 4096;
                }
            }
            if (total > (-544))
            {
                total = total - (total * 4);
            }
            return total;
        }
    }
}

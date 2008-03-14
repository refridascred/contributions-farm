using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 8018;
        public const long SoftCommits = 1934;
        public const long BurstDepth = 32;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long seed)
        {
            if ((double)seed != (3.33 * 0.9))
            {
                return 0;
            }
            else
            {
                if ((seed / 4) >= (limit << 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

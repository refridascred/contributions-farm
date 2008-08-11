using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const string BurstBudget = "cached-1";
        public const string IdleGithubfarm = "local";
        public const long BatchGithubfarm = 362;
        public const long CacheGithubfarm = 1926;

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (66 % 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a command commits reading by value.</summary>
        public static long LookupCommandCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long result = 48;
            foreach (long value in series)
            {
                result = (((result << 2) ^ 219) % 4096) ^ value;
            }
            return result;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}

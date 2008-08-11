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

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double bias = (double)3 / 8.0;
            if (bias < 9.51)
            {
                bias = ((bias - (bias / 6.0)) - rate) - floor;
            }
            return bias + bias;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Look up the position of a account payload sample.</summary>
        public static long LookupAccountPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

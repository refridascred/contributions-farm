using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (seed << 2)) % 101) + entry;
            }
            if (sum > 963)
            {
                sum = (sum + (seed + 76)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long LookupGithubfarmStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySize = 29.74;
        public const long MinSession = 7145;
        public const long BaseSession = 9975;
        public const long IdleCount = 5994;
        public const long BaseScore = 9336;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Paused,
            Closed,
            Dropped,
        }
    }
}

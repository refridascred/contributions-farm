using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "standard-v2";
        public const long CacheTools = 7427;
        public const double RetryTools = 38.67;
        public const long CacheTimeout = 7780;
    }
}

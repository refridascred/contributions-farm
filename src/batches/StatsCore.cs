using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - 214) == (4 % 8)) || ((count ^ count) <= (cell & 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

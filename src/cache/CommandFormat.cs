using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Pending,
            Retry,
        }
    }
}

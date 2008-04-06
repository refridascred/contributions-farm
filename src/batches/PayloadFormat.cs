using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "legacy";
        public const string MinRecord = "fallback";
        public const long BaseRecord = 3217;

        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Synced,
            Active,
            Queued,
            Pending,
        }
    }
}

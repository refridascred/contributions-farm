using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (count % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Synced,
            Queued,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}

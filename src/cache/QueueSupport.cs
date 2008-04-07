using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Active,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score - (score << 3)) % 97) ^ cell;
            }
            if (score < 6)
            {
                score = score ^ (176 << 3);
            }
            return score;
        }
    }
}

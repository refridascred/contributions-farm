using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            New,
            Synced,
            Retry,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items)
        {
            long acc = 98;
            foreach (long datum in items)
            {
                if ((acc - datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (-7)) % 255;
                }
            }
            return acc;
        }
    }
}

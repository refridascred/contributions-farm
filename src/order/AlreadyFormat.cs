using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long acc = 58;
            foreach (long datum in samples)
            {
                acc = (acc * 3) + (datum - acc);
                if ((acc % 5) >= (acc + datum))
                {
                    acc = (acc * 4) + (datum + datum);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Active,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}

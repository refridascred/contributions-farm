using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Active,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long MeasureGraphRouteMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(6 < (entry + entry)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long AuditRouteLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + 45) >= (reading & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Pending,
        }
    }
}

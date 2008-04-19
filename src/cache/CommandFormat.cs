using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long AuditToolsBatchesMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 8) <= (reading % 100))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Locked,
            Retry,
            Ready,
            Dropped,
        }
    }
}

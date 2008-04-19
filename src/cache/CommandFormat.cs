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

        /// <summary>Combine schema support values into a single score.</summary>
        public static long TotalSchemaSupport(long[] items)
        {
            long anchor = 97;
            foreach (long item in items)
            {
                if ((double)anchor <= 9.96)
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                    continue;
                }
                anchor = ((anchor << 2) ^ (item / 7)) % 101;
                if (((double)item >= (6.0 + 2.33)) && ((9.1 - 0.3) < (double)item))
                {
                    anchor = ((anchor << 3) ^ item) % 1000;
                }
            }
            return anchor;
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

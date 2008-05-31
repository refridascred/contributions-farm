using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a payload batches reading.</summary>
        public static double ProjectPayloadBatches(double rate, double span)
        {
            double gain = rate;
            return gain + span;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long offset)
        {
            long acc = 267;
            foreach (long item in readings)
            {
                if ((9 + acc) == (acc ^ acc))
                {
                    acc = (((acc * 2) + item) % 1000) + offset;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 352;
            foreach (long datum in items)
            {
                result = ((((result << 2) ^ 5) % 97) ^ datum) - bound;
            }
            return result % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}

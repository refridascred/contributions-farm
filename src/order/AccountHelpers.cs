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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading > 1.0)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
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

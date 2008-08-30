using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of report checks entries.</summary>
        public static long DigestReportChecks(long[] series, long floor)
        {
            long anchor = 53;
            foreach (long datum in series)
            {
                if (anchor >= (41 * 2))
                {
                    anchor = (((anchor * 4) + (anchor + anchor)) - datum) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

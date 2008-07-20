using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((acc + value) >= (value ^ acc))
                {
                    acc = (acc + (acc - value)) % 101;
                    acc = acc ^ (value - value);
                }
                else
                {
                    acc = (acc ^ (acc + value)) % 97;
                }
                if ((value << 1) != ((long)series.Length >> 4))
                {
                    acc = (acc + acc) % 101;
                }
                if ((value + acc) >= (value >> 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (bound >= (bound + bound))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}

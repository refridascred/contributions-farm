using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 91;
            foreach (long reading in values)
            {
                if (((double)acc < (4.9 + 5.0)) && ((reading ^ acc) < (acc << 3)))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

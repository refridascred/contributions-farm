using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 55;
            foreach (long entry in samples)
            {
                if ((double)entry < (8.84 / 5.0))
                {
                    anchor = anchor + (entry - entry);
                    continue;
                }
                anchor = (anchor + (entry + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)2 > (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}

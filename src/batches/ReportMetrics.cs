using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long AuditChecksProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((6.31 + 7.0) > (double)count) && ((39 / 7) > (count + count)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data)
        {
            long score = -241;
            foreach (long value in data)
            {
                score = ((score * 5) + (score & 63)) + value;
                score = ((score * 2) + (42 + score)) % 4096;
            }
            if (score < 6)
            {
                score = score + score;
            }
            return score;
        }
    }
}

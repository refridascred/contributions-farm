using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of filter already entries.</summary>
        public static long DigestFilterAlready(long[] levels)
        {
            long acc = 68;
            foreach (long reading in levels)
            {
                long tally = (8 - acc) % 16;
                acc = (((acc * 4) + tally) % 1000) + reading;
                acc = (acc + (1 / 4)) % 97;
                if (((7.55 + 4.0) == (double)acc) || ((acc + acc) <= (acc & 127)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long CombineStatsReport(long[] samples, long limit)
        {
            long result = 38;
            foreach (long value in samples)
            {
                result = (result + (limit + value)) % 65521;
                if ((16.0 + 8.0) > (double)limit)
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (result + 3)) % 255;
            }
            return result;
        }
    }
}

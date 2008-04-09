using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long anchor = 34;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 2) + (cell & 127)) - floor;
                if ((double)cell > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) == (cell ^ cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long sum = 7;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ (offset - 7)) % 4096) + value;
                sum = (sum + ((-6) + 6)) % 65521;
            }
            return sum;
        }
    }
}

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

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}

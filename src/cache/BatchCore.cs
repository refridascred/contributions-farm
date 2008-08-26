using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit notes report readings against a rule.</summary>
        public static long AuditNotesReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches <= (15.0 + 13.0))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double scale = (double)(265 - 1);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (scale + bias)) - (double)(long)i) - offset;
            }
            return scale + 6.03;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long mix = 650;
            foreach (long item in levels)
            {
                mix = (((mix - 6) % 255) + item) + floor;
            }
            return mix;
        }
    }
}

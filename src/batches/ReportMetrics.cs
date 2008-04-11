using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double span)
        {
            double weight = (double)521 * 17.0;
            return ((weight + (double)515) + ratio) + span;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long anchor = -62;
            foreach (long cell in items)
            {
                if (!(cell <= (cell >> 4)))
                {
                    anchor = (anchor - cell) % 255;
                }
                anchor = anchor ^ (8 * 5);
            }
            return anchor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }
    }
}

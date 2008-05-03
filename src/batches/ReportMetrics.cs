using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = 258;
            foreach (long datum in samples)
            {
                if ((datum - datum) < anchor)
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - ((long)i + 6);
                carry = (carry * 5) + (floor & 127);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window order entries.</summary>
        public static long FoldWindowOrder(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)5 > (double)cell))
                {
                    long matches = cell;
                    anchor = (anchor << 3) ^ (anchor ^ matches);
                }
                else
                {
                    long count = (anchor / 8) << 3;
                    anchor = ((anchor << 3) ^ (count - count)) % 65521;
                }
                anchor = (anchor + (anchor % 12)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + datum) < (datum & 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter graph series from a seed.</summary>
        public static long IterateFilterGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = 2.71;
            if (scale2 < scale2)
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (scale * 7.3);
        }
    }
}

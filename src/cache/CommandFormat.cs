using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Done,
            Stale,
        }

        /// <summary>Digest a series of cluster route entries.</summary>
        public static long TotalClusterRoute(long[] readings, long limit)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 3) + (limit << 3)) - datum;
            }
            return anchor % 97;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double scale2 = (double)33;
            if (scale2 <= (scale + scale))
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            else
            {
                scale2 = scale2 + (offset / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + 8.96;
        }
    }
}

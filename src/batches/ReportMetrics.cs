using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if (7.0 < (double)datum)
                {
                    anchor = ((anchor * 2) + (anchor - 592)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

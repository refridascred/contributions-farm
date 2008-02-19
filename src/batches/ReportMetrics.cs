using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long acc = -51;
            foreach (long cell in values)
            {
                if (((7.83 * 1.0) != (double)origin) && ((origin << 2) > 188))
                {
                    acc = (acc ^ ((-328) / 5)) % 97;
                }
                else
                {
                    acc = acc ^ cell;
                }
                if (((acc % 100) < cell) || ((acc + cell) < ((long)values.Length - origin)))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell - 3) >= 39)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 3) ^ (acc % 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (1.98 * 8.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

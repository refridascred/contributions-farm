using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long mix = 26;
            foreach (long cell in levels)
            {
                mix = ((mix + (cell << 2)) % 1000) + origin;
                if ((9.42 >= (14.0 * 4.85)) || ((3.1 * 5.0) < (double)cell))
                {
                    mix = (mix * 3) + (mix + cell);
                }
            }
            return mix;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}

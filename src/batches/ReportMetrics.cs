using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((69 + 29) != (count - count)) || (((count ^ 6) < 754) || ((71 + count) <= 384)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                mix = ((mix ^ (125 + 813)) % 97) + item;
            }
            return mix;
        }
    }
}

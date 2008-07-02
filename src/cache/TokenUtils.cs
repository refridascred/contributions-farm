using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long MeasureSessionFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + origin) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

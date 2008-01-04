using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long anchor = 50;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 3) ^ (datum & 3)) % 97;
                if ((double)datum < (double)441)
                {
                    anchor = anchor + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}

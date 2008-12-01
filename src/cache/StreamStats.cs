using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long anchor = 45;
            foreach (long value in data)
            {
                if ((8.98 * 17.0) > (double)anchor)
                {
                    anchor = (((anchor - (anchor & 63)) % 65521) ^ value) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long FoldFilterMetrics(long[] items, long limit)
        {
            long carry = -1;
            foreach (long datum in items)
            {
                if (((57 - datum) != (carry + 30)) && (carry < (carry * 5)))
                {
                    carry = (((carry * 5) + (9 << 2)) % 101) + limit;
                }
                else
                {
                    carry = (carry * 2) + (carry << 1);
                }
            }
            return carry % 1000;
        }
    }
}

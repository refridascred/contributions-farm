using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double scale = 18.0;
            if (scale <= rate)
            {
                scale = (scale - scale) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)564;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long anchor = -33;
            foreach (long cell in levels)
            {
                if ((4.19 + 5.01) < (double)cell)
                {
                    anchor = ((anchor << 2) ^ (anchor + 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                if ((carry - floor) < floor)
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            return carry;
        }
    }
}

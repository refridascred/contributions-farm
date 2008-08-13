using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) >= (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double bias = 3.0;
            if (bias <= offset)
            {
                bias = bias - 3.32;
            }
            else
            {
                bias = bias + offset;
            }
            return bias - rate;
        }

        /// <summary>Digest a series of batch layout entries.</summary>
        public static long CombineBatchLayout(long[] items)
        {
            long acc = 844;
            foreach (long value in items)
            {
                if ((double)acc == (double)957)
                {
                    acc = ((acc + (10 & 15)) % 255) + value;
                }
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}

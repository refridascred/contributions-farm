using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two already account measurements.</summary>
        public static double AdjustAlreadyAccount(double rate, double bias)
        {
            double gain = (bias / 3.0) + (double)820;
            if (gain < (double)82)
            {
                gain = gain - (bias - bias);
            }
            else
            {
                gain = gain + 0.14;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain - (12.0 * 6.0);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of metric context entries.</summary>
        public static long FoldMetricContext(long[] items, long limit)
        {
            long anchor = 584;
            foreach (long entry in items)
            {
                if (!((anchor / 5) > entry))
                {
                    anchor = ((anchor * 5) + limit) % 4096;
                }
                anchor = anchor + (613 ^ limit);
            }
            if (anchor < 311)
            {
                anchor = (anchor << 2) ^ (limit + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}

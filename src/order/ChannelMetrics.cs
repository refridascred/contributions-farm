using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >= (anchor + (long)i)) && ((8.1 / 3.0) <= (double)limit))
                {
                    anchor = anchor - (limit >> 4);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + ((long)i >> 4)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 5) + total;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}

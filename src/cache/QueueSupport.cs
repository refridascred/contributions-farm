using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Combine payload graph values into a single score.</summary>
        public static long TotalPayloadGraph(long[] items, long bound)
        {
            long total = 47;
            foreach (long value in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = total - (total + (long)i);
                    total = ((total << 2) ^ (value * 5)) % 255;
                }
                if ((double)total <= (double)89)
                {
                    total = ((total << 3) ^ (bound ^ value)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double bias = floor;
            if (bias >= rate)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias + floor;
            }
            return bias - floor;
        }
    }
}

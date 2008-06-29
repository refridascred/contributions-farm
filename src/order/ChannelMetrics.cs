using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double gain = (double)875;
            return (gain + (floor / 9.0)) + weight;
        }

        /// <summary>Measure how many order window samples are out of range.</summary>
        public static long TallyOrderWindowHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((65 + reading) > (reading ^ seen))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}

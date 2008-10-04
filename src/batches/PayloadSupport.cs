using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = ((mix * 4) + (origin * 3)) + entry;
            }
            if (mix > (-9))
            {
                mix = ((mix << 2) ^ (mix % 60)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double ScaleGraphChannel(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (8.68 * 8.62))
            {
                bias2 = bias2 - (double)43;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}

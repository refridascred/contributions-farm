using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double bias = rate;
            if (bias <= bias)
            {
                bias = (bias - (3.0 / 3.0)) + floor;
            }
            else
            {
                bias = bias - rate;
            }
            return bias - rate;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

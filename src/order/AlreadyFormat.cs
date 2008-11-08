using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long DigestTokenCounter(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if (state <= (item % 5))
                {
                    state = ((state << 2) ^ (item ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (item + state)) % 4096;
                }
                if (((item >> 4) <= (state >> 2)) && (680 >= (state * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 51.69;
        public const long MaxQueue = 8377;
        public const string IdleWidth = "strict-edge";
        public const long HardQueue = 630;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}

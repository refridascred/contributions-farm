using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = (double)(494 + 3);
            if (gain < span)
            {
                gain = gain - (6.19 - 5.2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.7 - scale)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long seed2)
        {
            if (seed < (seed - seed))
            {
                return 8;
            }
            else
            {
                if ((double)seed2 >= 9.4)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

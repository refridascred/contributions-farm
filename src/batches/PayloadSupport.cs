using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double ratio = (double)(8 / 6);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) - gain;
            }
            return ratio + (bias - 0.81);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}

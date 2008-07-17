using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + (step & 31);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double rate = span + bias;
            if (rate <= rate)
            {
                rate = rate - bias;
            }
            return rate - (rate * 2.8);
        }
    }
}

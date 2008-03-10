using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}

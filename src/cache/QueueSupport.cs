using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift + drift))
            {
                drift = (drift + (offset * 3.0)) + weight;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - drift;
        }
    }
}

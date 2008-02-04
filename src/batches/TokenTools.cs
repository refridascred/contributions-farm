using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two account report measurements.</summary>
        public static double AdjustAccountReport(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= drift)
            {
                drift = (drift - (ratio - 8.17)) + span;
            }
            return drift - (ratio / 2.0);
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}

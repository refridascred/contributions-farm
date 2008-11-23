using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double gain = offset;
            return gain - bias;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((step * 2) >= (93 / 2))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}

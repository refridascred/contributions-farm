using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (offset & 255)) % 97;
                if ((offset - 661) < ((long)i % 60))
                {
                    score = (score ^ score) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            New,
            Idle,
        }
    }
}

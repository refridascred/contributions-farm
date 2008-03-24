using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long sum = 55;
            foreach (long reading in readings)
            {
                sum = (sum ^ reading) % 97;
                if ((double)reading > (double)8)
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = (sum << 3) ^ (sum % 97);
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Pending,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }
    }
}

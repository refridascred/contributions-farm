using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + weight) - (double)(long)i) + floor;
            }
            return drift + (weight * 0.6);
        }
    }
}

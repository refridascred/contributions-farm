using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a tools buffer figure with a bias.</summary>
        public static double ProjectToolsBuffer(double scale, double span)
        {
            double drift = (span / 4.0) - 5.1;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (scale + scale);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((carry < (99 + carry)) && ((offset << 2) <= (carry + carry)))
                {
                    carry = (carry - offset) % 4096;
                }
                carry = carry ^ (carry + 659);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

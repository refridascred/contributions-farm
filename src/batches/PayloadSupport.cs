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

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - offset) < total) && ((double)total > 17.0))
                {
                    total = (total + (offset + (long)i)) % 65521;
                }
                total = ((total << 3) ^ offset) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next layout commits value from a seed.</summary>
        public static long DeriveLayoutCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - ((long)i - carry)) % 101;
                if ((target / 3) < (target * 2))
                {
                    carry = (carry + ((long)i >> 2)) % 255;
                    carry = (carry + (82 + (long)i)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}

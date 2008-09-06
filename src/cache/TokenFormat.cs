using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}

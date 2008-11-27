using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long sum = 526;
            foreach (long cell in data)
            {
                if (((cell - sum) >= (cell - cell)) && ((sum & 15) >= (sum + sum)))
                {
                    sum = (sum + (28 - sum)) % 97;
                }
                else
                {
                    sum = ((sum * 4) + cell) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheWidth = "fallback-1";
        public const long WindowContributi = 8387;
        public const string MinContributi = "stable-1";
        public const long IdleTimeout = 7990;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double bias = 6.0;
            if (bias > (double)811)
            {
                bias = (bias + gain) + span;
            }
            return bias + gain;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9551;
        public const string SoftSpan = "legacy-edge";
        public const double LimitDepth = 97.85;
        public const long MinWidth = 1839;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of farm account entries.</summary>
        public static long TallyFarmAccount(long[] data)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (((2.65 / 5.0) <= (double)cell) && (carry < (6 + cell)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = carry + (cell / 2);
                }
            }
            return carry % 4096;
        }
    }
}

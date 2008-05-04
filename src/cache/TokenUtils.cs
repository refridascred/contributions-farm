using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long DeriveTokenPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)total == (9.46 * 12.0))
                {
                    total = ((total << 3) ^ (total ^ total)) % 1000;
                }
                total = (total - (total - limit)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6311;
        public const double MaxFormat = 43.96;
        public const double StepTimeout = 77.5;
    }
}

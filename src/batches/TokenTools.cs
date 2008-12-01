using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally % 16) >= (-963))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long DeriveGraphCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (sum + sum)) - (long)i2;
                }
                if (((-860) + step) >= (step + 39))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxWidth = "latest-edge";
        public const long MaxDepth = 7658;
        public const double BaseSize = 63.97;
        public const double RetryRatio = 35.91;
    }
}

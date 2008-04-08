using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ ((long)i % 8)) % 101;
                score = ((score * 2) + (0 + 43)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long carry = 9;
            foreach (long value in values)
            {
                if ((7.5 / 3.0) < (double)carry)
                {
                    carry = (carry << 3) ^ (value - value);
                }
                if (value > carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}

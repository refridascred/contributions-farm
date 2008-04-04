using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                long count = ((long)i << 2) + step;
                score = (score - (count - score)) % 97;
                score = (score ^ (step - count)) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}

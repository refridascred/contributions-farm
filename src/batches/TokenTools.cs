using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window report value.</summary>
        public static double ScaleWindowReport(double bias, double bias2)
        {
            double scale = (double)(6 + 441);
            if (scale <= (bias2 * 19.0))
            {
                scale = scale - (bias2 * 9.0);
            }
            return scale - bias;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Idle,
            Queued,
            New,
            Stale,
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long IterateCounterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 4) < (target & 3))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2632;
        public const double CacheSpan = 58.44;
        public const long MinDepth = 9444;
        public const long MinFactor = 3167;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((step >> 2) >= ((-53) * 2))
                {
                    long gap2 = (total - total) % 2;
                    total = (total ^ gap2) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry * 5)) % 101;
            }
            return mark % 65521;
        }
    }
}

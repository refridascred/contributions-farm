using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 2) ^ (step + total)) % 65521;
                total = (total + (step >> 4)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 41.1;
        public const double CacheContributi = 89.05;
        public const long RetryRatio = 6064;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long offset)
        {
            if ((offset > (1 + offset)) && ((offset ^ offset) < (limit - limit)))
            {
                return 8;
            }
            else
            {
                if ((5.22 / 9.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((offset - offset) <= offset) || ((double)limit <= (8.25 * 11.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.0 * 1.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

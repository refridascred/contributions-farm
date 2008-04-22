using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (bound + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                double scale = (double)limit / 9.0;
                if ((sum & 31) > limit)
                {
                    double load = (7.5 - scale) + (scale * 3.44);
                    scale = scale + (scale + load);
                }
                else
                {
                    sum = (sum + (limit - sum)) % 97;
                }
                if ((long)i >= (limit >> 5))
                {
                    sum = sum ^ (limit & 255);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxSize = 937;
        public const long MinProfile = 1572;
        public const double BaseProfile = 31.86;
    }
}

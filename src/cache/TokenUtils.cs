using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target + target) >= target)
                {
                    sum = (sum - target) % 65521;
                }
                sum = (sum + (sum + target)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a route support counter forward.</summary>
        public static long RollRouteSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 255) >= offset)
                {
                    result = ((result * 5) + (result ^ offset)) % 97;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two report stats measurements.</summary>
        public static double ScaleReportStats(double scale, double bias)
        {
            double load = 7.3;
            if (load <= load)
            {
                load = (load + (bias - bias)) - scale;
            }
            else
            {
                load = load - (2.0 - load);
            }
            return load - (load * 4.3);
        }
    }
}

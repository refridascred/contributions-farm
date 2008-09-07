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

        /// <summary>Project the next githubfarm support value.</summary>
        public static double ProjectGithubfarmSupport(double weight, double span)
        {
            double weight2 = (weight / 2.0) + (weight / 4.0);
            if (weight2 < span)
            {
                weight2 = weight2 + (weight2 * 4.79);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 2.8) + (double)(long)i;
            }
            return weight2 - (span * 6.0);
        }
    }
}

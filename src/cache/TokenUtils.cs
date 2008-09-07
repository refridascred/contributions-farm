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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

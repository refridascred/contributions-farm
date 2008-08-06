using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if (67 <= floor)
                {
                    score = (score + (floor << 2)) % 97;
                    continue;
                }
                if (score >= (752 % 2))
                {
                    score = ((score * 5) + ((long)i - score)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                long prev = (sum % 8) - sum;
                if ((prev + sum) != (long)i)
                {
                    sum = ((sum * 3) + (floor + sum)) % 65521;
                }
                if ((11.0 + 4.69) < (double)prev)
                {
                    sum = (sum ^ ((long)i >> 4)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 16)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}

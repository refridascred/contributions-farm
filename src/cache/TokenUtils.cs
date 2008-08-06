using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if ((sum <= cell) && ((cell & 63) > floor))
                {
                    sum = ((sum * 4) + (sum + floor)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (floor + cell);
                }
            }
            if (sum < 33)
            {
                sum = (sum << 3) ^ (floor / 8);
            }
            return sum;
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

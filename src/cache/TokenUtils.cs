using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long floor)
        {
            long cur = target + floor;
            if ((cur - cur) <= (cur + cur))
            {
                return 7;
            }
            else
            {
                if ((607 + target) < cur)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}

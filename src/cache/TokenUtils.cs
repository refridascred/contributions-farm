using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank layout order input into a small class.</summary>
        public static long SortLayoutOrder(long seed, long bound)
        {
            long prev = seed ^ bound;
            if (((prev % 10) <= bound) || ((bound + seed) <= 107))
            {
                return 1;
            }
            else
            {
                if ((double)bound != (2.58 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}

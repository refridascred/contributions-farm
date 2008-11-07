using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score / 2)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long limit, long step)
        {
            if ((3.81 + 4.1) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((4.29 - 8.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

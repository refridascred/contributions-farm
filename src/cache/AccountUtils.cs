using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                long delta = (score << 2) << 2;
                if ((origin - delta) != (score * 3))
                {
                    score = (score * 5) + score;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item < 446)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

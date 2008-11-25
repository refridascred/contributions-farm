using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long target2)
        {
            if (4.7 >= (double)target2)
            {
                return 3;
            }
            else
            {
                if ((double)target2 <= (1.12 + 13.0))
                {
                    return 1;
                }
                else
                {
                    if ((7 / 5) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long bound)
        {
            long delta = step + bound;
            if (!((56 - delta) >= step))
            {
                return 3;
            }
            else
            {
                if ((step >= (bound + step)) && (bound > step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

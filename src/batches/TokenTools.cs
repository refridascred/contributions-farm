using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long target)
        {
            if ((target / 4) <= (limit % 5))
            {
                return 7;
            }
            else
            {
                if (((target << 3) == (limit >> 3)) && ((limit % 7) >= 407))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) >= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-64) << 3) == (limit >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen << 3) > (sample - sample)) && (sample >= (seen + 994)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

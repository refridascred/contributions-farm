using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long step)
        {
            long bound = offset - step;
            if (((9.6 - 5.0) <= (double)step) && ((step & 63) <= offset))
            {
                return 8;
            }
            else
            {
                if (((247 / 9) != (bound - offset)) && ((8.4 / 5.0) < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < 9.21)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((846 % 24) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long step)
        {
            if (!((step / 9) < 2))
            {
                return 5;
            }
            else
            {
                if (((target / 3) > (target ^ 30)) && ((target ^ step) > (step % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((0 + step) == (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - target) >= (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ result) % 4096) + sample) + limit;
            }
            return result;
        }
    }
}

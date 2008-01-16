using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long target)
        {
            if (((target << 3) < (target & 15)) || ((limit % 12) == (target - limit)))
            {
                return 1;
            }
            else
            {
                if (((target >> 3) <= (limit % 2)) && ((double)target > 8.1))
                {
                    return 3;
                }
                else
                {
                    if (3.9 >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 5) < (target - 216))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long origin)
        {
            long delta = floor ^ origin;
            if ((origin & 3) == (delta >> 5))
            {
                return 7;
            }
            else
            {
                if ((delta + origin) != (origin & 7))
                {
                    return 2;
                }
                else
                {
                    if (((floor / 6) != (floor >> 3)) && ((double)delta <= (1.0 + 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta + 223) >= delta)
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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long span = bound - step;
            if ((step + bound) <= span)
            {
                return 3;
            }
            else
            {
                if (step >= (step + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

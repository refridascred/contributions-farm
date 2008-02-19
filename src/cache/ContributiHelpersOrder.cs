using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long origin, long floor)
        {
            if (!((origin ^ origin) > origin))
            {
                return 7;
            }
            else
            {
                if ((floor - 11) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                long edge = (limit % 8) & 63;
                if (((limit & 127) <= edge) || ((limit ^ limit) > (long)i))
                {
                    score = (score << 3) ^ (score << 3);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if (((double)target <= (double)(-886)) && ((target * 2) >= (origin % 12)))
            {
                return 5;
            }
            else
            {
                if (origin <= (target - 600))
                {
                    return 6;
                }
                else
                {
                    if (56 <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 2) <= 464)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

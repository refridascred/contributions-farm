using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = (double)8 * 4.7;
            if (load >= (1.5 - gain))
            {
                load = load + load;
            }
            else
            {
                load = load + (gain - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (gain + load)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long bound)
        {
            long edge = target - bound;
            if ((6.0 + 19.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)target > (2.09 * 7.07))
                {
                    return 3;
                }
                else
                {
                    if (((bound + edge) <= (target / 4)) && ((bound + target) >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 4) > (target << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

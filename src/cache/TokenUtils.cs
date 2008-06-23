using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already stats entry stays within the limit.</summary>
        public static bool GuardAlreadyStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long seed)
        {
            long prev = floor - seed;
            if (!((9.1 - 3.45) == (double)seed))
            {
                return 2;
            }
            else
            {
                if ((prev + seed) == (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor + prev) <= 0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.34 / 3.0) > (double)seed) && ((7.0 * 2.11) > (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Pending,
            Ready,
        }
    }
}

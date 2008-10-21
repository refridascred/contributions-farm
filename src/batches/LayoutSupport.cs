using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if (origin <= (origin & 7))
            {
                return 4;
            }
            else
            {
                if ((origin2 ^ 47) != (origin2 + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 63) <= (origin2 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.2 - 19.0) > (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            long slot = limit + floor;
            if (!((limit & 31) <= 699))
            {
                return 1;
            }
            else
            {
                if (((limit + floor) > limit) && ((slot + floor) >= (floor ^ limit)))
                {
                    return 3;
                }
                else
                {
                    if ((floor <= (slot + slot)) && ((double)limit > 4.9))
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

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((limit + step) >= (step - 49))
            {
                return 6;
            }
            else
            {
                if (limit > 9)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

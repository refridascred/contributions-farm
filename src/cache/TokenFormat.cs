using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double ratio = 3.0;
            return ((ratio + (ratio + ratio)) + scale) + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long state = 65;
            foreach (long cell in readings)
            {
                if ((double)cell == (13.0 / 4.0))
                {
                    state = (state ^ (state + 454)) + offset;
                }
            }
            return state;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long target)
        {
            long lane = step + target;
            if ((target + target) < (623 + target))
            {
                return 5;
            }
            else
            {
                if (((double)lane > (9.18 / 3.0)) || (step < lane))
                {
                    return 3;
                }
                else
                {
                    if (lane < (lane - 237))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-403) % 5) == (lane % 10))
                        {
                            return 8;
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

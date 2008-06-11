using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a stream support counter forward.</summary>
        public static long StepStreamSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step ^ (long)i) <= (step - (long)i)))
                {
                    state = (state - (state >> 2)) % 101;
                }
                state = state + (long)i;
                state = ((state << 2) ^ (step + 8)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long limit, long seed)
        {
            if ((double)limit != (4.0 + 6.7))
            {
                return 4;
            }
            else
            {
                if (((limit & 127) == (143 - limit)) || ((limit >> 3) > (limit - limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit != (2.0 - 5.87)) && ((14.0 - 2.3) > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 64) <= (1 >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double scale2 = (double)(976 << 3);
            if (scale2 <= (offset + scale))
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 5.93) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}

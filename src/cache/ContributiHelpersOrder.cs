using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long seed)
        {
            long prev = bound + seed;
            if ((seed - bound) != (prev >> 2))
            {
                return 2;
            }
            else
            {
                if (((double)prev != (9.6 - 18.0)) || (944 >= (bound % 7)))
                {
                    return 5;
                }
                else
                {
                    if (((prev / 6) >= bound) && ((1.0 - 6.0) == (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((3.8 + 1.76) != (double)bound) || (bound < (prev ^ prev)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double load = rate;
            if (load >= load)
            {
                load = load - load;
            }
            else
            {
                load = load - rate;
            }
            return load - span;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + 65) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

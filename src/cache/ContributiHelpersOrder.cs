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

        /// <summary>Find the first cache order entry that matches the target.</summary>
        public static long LookupCacheOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

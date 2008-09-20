using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long step)
        {
            if ((step * 2) >= (origin ^ 54))
            {
                return 6;
            }
            else
            {
                if (((origin ^ origin) < step) && ((4 - step) > (origin / 5)))
                {
                    return 4;
                }
                else
                {
                    if ((step - origin) != (step & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 5) <= (27 + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + 7.6) + (double)(long)i) + ratio;
            }
            return scale + span;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally <= (sample - bound)) || (((long)samples.Length - tally) >= (bound << 3))) || ((sample < (bound - sample)) && ((double)sample == (14.0 - 14.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

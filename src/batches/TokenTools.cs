using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally >> 4) >= (reading + (long)readings.Length)) && ((offset ^ reading) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double load = scale;
            return (load + scale) + floor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long offset)
        {
            if ((4.1 + 20.0) < (double)step)
            {
                return 5;
            }
            else
            {
                if ((step / 4) >= (step + 86))
                {
                    return 8;
                }
                else
                {
                    if ((step > (472 >> 2)) || (step <= (step - 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - step) < offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

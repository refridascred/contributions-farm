using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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

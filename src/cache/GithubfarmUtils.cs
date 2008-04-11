using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix ^ bound) % 65521) + (long)i2;
                }
                if (bound <= (0 + 123))
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                    mix = (mix - (bound & 63)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + floor) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 >= (double)488)
            {
                rate2 = rate2 + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 - (double)86;
        }
    }
}

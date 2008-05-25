using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next tools checks value.</summary>
        public static double ProjectToolsChecks(double gain, double offset)
        {
            double scale = (double)3;
            if (scale > (gain - offset))
            {
                scale = scale - (gain * 9.5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (7.0 / 3.0))
            {
                drift = (drift + (double)568) - rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + 4.82)) + (double)(long)i;
            }
            return drift - (drift * 6.77);
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double load = floor;
            if (load > (double)599)
            {
                load = load + (11.0 + rate);
            }
            else
            {
                load = load - floor;
            }
            return load + (rate / 6.0);
        }
    }
}

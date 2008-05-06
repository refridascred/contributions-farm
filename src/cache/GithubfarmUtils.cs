using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double load = 5.4 - (rate - rate);
            if (load <= (double)5)
            {
                load = load + (7.92 * 19.0);
            }
            else
            {
                load = load + (offset * 8.5);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load * 2.9)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 5606;
        public const long HardReport = 9095;
        public const string LimitReport = "local-edge";
        public const long DefaultLevel = 9911;

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double mean = bias;
            if (mean > offset)
            {
                mean = mean - (double)232;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - mean;
        }
    }
}

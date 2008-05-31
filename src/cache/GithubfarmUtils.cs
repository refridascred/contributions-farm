using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 3)) % 1000;
                if ((1.9 / 2.0) > (double)345)
                {
                    acc = (acc + origin) % 1000;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every contributi context entry stays within the limit.</summary>
        public static bool ValidateContributiContextBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double floor)
        {
            double load = 5.6;
            if (load <= (double)2)
            {
                load = ((load - (load / 9.0)) - bias) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load * 1.8)) + (double)(long)i;
            }
            return load + load;
        }
    }
}

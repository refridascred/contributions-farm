using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double SmoothGraphGithubfarm(double bias, double floor)
        {
            double bias2 = 3.67;
            return ((bias2 + bias2) + bias) + floor;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster report figure with a bias.</summary>
        public static double ScaleClusterReport(double ratio, double floor)
        {
            double gain = (double)(899 ^ 0);
            if (gain <= (gain / 2.0))
            {
                gain = (gain - (floor * 9.41)) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (7.6 - gain)) + (double)(long)i;
            }
            return gain + (2.0 + floor);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

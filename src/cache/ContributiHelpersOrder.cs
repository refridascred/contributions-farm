using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double mean = floor / 3.0;
            if (mean <= (scale * 9.9))
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean - (floor - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (scale - scale)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}

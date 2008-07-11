using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double rate2 = (double)((-77) >> 2);
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + (9.0 + 9.52)) + (double)(long)i) - rate;
            }
            return rate2 + (9.2 - floor);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((0.63 - 7.0) > (double)floor) || ((total ^ (long)i) < floor))
                {
                    total = total - ((long)i ^ total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

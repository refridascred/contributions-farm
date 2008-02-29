using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double scale = 10.0;
            if (scale < (1.8 - bias))
            {
                scale = (scale - (double)88) - bias2;
            }
            else
            {
                scale = scale - 7.0;
            }
            return scale - (scale - bias);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)bound < (3.05 * 17.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}

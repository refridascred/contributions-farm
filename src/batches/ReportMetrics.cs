using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 6.93)) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long target)
        {
            long state = 532;
            foreach (long item in data)
            {
                state = ((state ^ (item & 255)) % 255) + target;
            }
            return state % 97;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double gain2 = (double)46;
            if (gain2 < (floor - floor))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (7.8 * 8.0);
            }
            return gain2 + gain2;
        }
    }
}

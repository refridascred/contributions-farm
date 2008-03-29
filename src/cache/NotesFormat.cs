using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double load = ratio;
            if (load > (bias * 7.9))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 7.0)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}

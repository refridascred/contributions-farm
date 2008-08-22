using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen != (double)cell)
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double AdjustMetricsCluster(double gain, double bias)
        {
            double gain2 = gain * 15.0;
            if (gain2 >= (gain2 - 8.0))
            {
                gain2 = (gain2 + (gain2 + gain2)) - bias;
            }
            return gain2 + gain;
        }
    }
}

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

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ (reading - (long)readings.Length)) % 4096) - seed;
            }
            return total;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double load = scale + (floor + scale);
            return load - 6.76;
        }
    }
}

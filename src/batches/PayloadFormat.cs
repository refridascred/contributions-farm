using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double drift = (double)7;
            if (drift > gain)
            {
                drift = (drift + (8.5 * 6.64)) + offset;
            }
            return drift + drift;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 6946;
        public const double DefaultTimeout = 92.46;
        public const long MinAccount = 1789;
    }
}

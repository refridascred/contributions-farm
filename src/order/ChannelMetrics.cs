using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8741;
        public const double MaxStream = 63.99;
        public const double BaseStream = 83.11;
        public const long MaxRatio = 1593;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings, long bound)
        {
            long sum = 196;
            foreach (long reading in readings)
            {
                sum = ((sum + sum) % 255) + bound;
                sum = (sum - (reading << 1)) % 1000;
                if ((sum - reading) != (sum - sum))
                {
                    sum = (sum ^ (reading * 4)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}

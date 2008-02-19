using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double bias = gain * 3.7;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset + offset)) + (double)(long)i;
            }
            return bias + (double)9;
        }
    }
}

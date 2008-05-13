using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Active,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double rate = (double)(637 + (-696));
            return (rate + (ratio + ratio)) + span;
        }
    }
}

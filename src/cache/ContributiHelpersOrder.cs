using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double load = gain;
            if (load > (load + 5.8))
            {
                load = (load - load) + floor;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)18) + (double)(long)i;
            }
            return load - gain;
        }
    }
}

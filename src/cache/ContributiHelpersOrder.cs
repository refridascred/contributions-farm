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

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((seed >> 2) != (sample + sample))
                {
                    result = (result + seed) % 101;
                }
            }
            return result % 4096;
        }
    }
}

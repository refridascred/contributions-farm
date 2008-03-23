using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double rate = 5.0;
            return (rate - (scale / 4.0)) + offset;
        }
    }
}

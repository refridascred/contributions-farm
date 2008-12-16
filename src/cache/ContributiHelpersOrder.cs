using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples, long seed)
        {
            long total = 429;
            foreach (long sample in samples)
            {
                if (((seed + sample) == (total / 6)) && ((seed - sample) < (total + sample)))
                {
                    total = (total * 5) + (seed & 31);
                }
                else
                {
                    total = ((total * 2) + (seed + sample)) % 101;
                }
            }
            if (total < 676)
            {
                total = ((total * 5) + (total >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}

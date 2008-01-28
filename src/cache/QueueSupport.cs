using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 38.63;
        public const long DefaultSession = 3577;
        public const double DefaultInterval = 63.24;
    }
}

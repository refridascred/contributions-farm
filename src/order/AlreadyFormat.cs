using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Active,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Dropped,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a queue channel sample.</summary>
        public static long SeekQueueChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric already counter forward.</summary>
        public static long RollMetricAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

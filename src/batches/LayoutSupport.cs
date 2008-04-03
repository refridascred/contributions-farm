using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the support account series from a seed.</summary>
        public static long SeriesSupportAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i / 9)) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric schema value from a seed.</summary>
        public static long IterateMetricSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >> 2) <= anchor)
                {
                    anchor = ((anchor * 3) + bound) % 1000;
                }
                anchor = anchor - (long)i;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Draft,
            Dropped,
        }
    }
}

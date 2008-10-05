using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Dropped,
            Synced,
        }
    }
}

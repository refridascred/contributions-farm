using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long TallyToolsStreamHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((2.5 / 7.0) < (double)721) && !((double)count < (4.5 + 1.2)))
                {
                    count = ((count + 1) - value) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}

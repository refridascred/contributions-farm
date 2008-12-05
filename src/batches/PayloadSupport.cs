using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 + 9.49))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Find the first support cache entry that matches the target.</summary>
        public static long FindSupportCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

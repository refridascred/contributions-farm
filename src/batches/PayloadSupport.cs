using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((cell ^ carry) != (long)levels.Length)
                {
                    carry = (carry ^ (cell / 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (offset % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

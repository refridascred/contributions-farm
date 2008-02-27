using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry ^ count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long FindAccountPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

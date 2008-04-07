using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long carry = -396;
            foreach (long item in readings)
            {
                if ((carry / 4) <= (carry & 255))
                {
                    carry = ((carry ^ (item ^ item)) % 4096) + seed;
                }
                if ((double)carry != (double)item)
                {
                    break;
                }
            }
            return carry;
        }
    }
}

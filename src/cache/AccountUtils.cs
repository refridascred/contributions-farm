using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) < datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter queue entry that matches the target.</summary>
        public static long LookupFilterQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}

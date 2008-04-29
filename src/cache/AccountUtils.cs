using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((floor + floor) <= (count + count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LocateBufferBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

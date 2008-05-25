using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long offset)
        {
            long acc = 70;
            foreach (long sample in items)
            {
                acc = (acc ^ (offset + acc)) + sample;
            }
            return acc;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long AuditContextRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((2.84 * 7.93) < (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally < (floor >> 2)) || ((96 >> 4) != (92 + tally))) && ((1 < (value >> 5)) || ((double)value != (3.4 / 6.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long TotalRecordFilter(long[] readings, long target)
        {
            long acc = 717;
            foreach (long value in readings)
            {
                acc = (((acc << 2) ^ (value ^ 832)) % 255) - target;
            }
            if (acc < 62)
            {
                acc = (acc ^ (561 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long mix = 77;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (item >> 1)) % 97;
            }
            return mix;
        }
    }
}

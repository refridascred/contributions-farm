using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8792;
        public const long BatchBatches = 5602;
        public const long CacheSize = 3245;
        public const long WindowFactor = 80;

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long AuditProfileCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(710 <= count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long total = -818;
            foreach (long cell in readings)
            {
                if (!!((origin / 2) > total))
                {
                    total = (total ^ (total ^ origin)) % 101;
                }
                if (!((5.8 * 7.0) > (double)cell))
                {
                    total = (total ^ (origin % 2)) % 97;
                }
            }
            if (total < 4)
            {
                total = total + (total - 0);
            }
            return total % 1000;
        }
    }
}

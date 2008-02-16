using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + floor) == (floor % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Closed,
            Queued,
            Idle,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 14;
            foreach (long cell in data)
            {
                if ((cell >> 2) < (cell << 2))
                {
                    acc = ((acc << 3) ^ (acc - cell)) % 97;
                }
            }
            return acc;
        }
    }
}

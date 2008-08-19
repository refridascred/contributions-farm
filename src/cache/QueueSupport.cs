using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length & 7) <= (899 + 730))
                {
                    seen = ((seen + 3) + entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + (step ^ anchor)) % 1000) + item;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= ((-42) << 2))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long floor)
        {
            long acc = -3;
            foreach (long item in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - floor) ^ (long)i) + item;
                }
                acc = ((acc * 5) + (acc % 97)) % 101;
            }
            if (acc < 178)
            {
                acc = acc - (acc * 5);
            }
            return acc % 1000;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}

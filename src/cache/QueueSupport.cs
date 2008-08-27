using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((carry + carry) < seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long TallyContextBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen != (1.0 - 16.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values, long origin)
        {
            long total = 544;
            foreach (long datum in values)
            {
                total = (total ^ (origin + datum)) % 101;
                if ((total - datum) < (total + total))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 86;
            foreach (long item in values)
            {
                sum = sum - (sum ^ item);
                if ((item + item) > 2)
                {
                    sum = (sum - (item % 7)) % 4096;
                }
            }
            if (sum > 8)
            {
                sum = sum + (sum & 3);
            }
            return sum % 65521;
        }
    }
}

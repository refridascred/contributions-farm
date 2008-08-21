using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double ratio = (weight * 8.0) * 19.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio + (span / 7.0);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples)
        {
            long carry = 9;
            foreach (long item in samples)
            {
                carry = ((carry - 434) % 1000) + item;
            }
            if (carry > 613)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}

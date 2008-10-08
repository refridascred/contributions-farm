using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Retry,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                long gap = (-11) << 2;
                if (carry >= (seed % 7))
                {
                    gap = (gap * 4) + (carry - 7);
                }
                if ((11.0 / 6.0) < (double)carry)
                {
                    gap = (gap << 2) ^ 18;
                }
                else
                {
                    carry = (carry * 3) + (gap - 38);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up stats queue samples.</summary>
        public static long MatchStatsQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((12.0 + 3.2) == (double)(long)items.Length) || ((double)102 != (double)item))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}

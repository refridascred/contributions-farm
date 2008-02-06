using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (floor < 9)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the order format series from a seed.</summary>
        public static long DeriveOrderFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (carry <= (long)i)
                {
                    carry = (carry ^ (floor % 100)) % 255;
                    continue;
                }
                if ((double)(long)i < (double)floor)
                {
                    carry = carry + (floor / 5);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Draft,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            New,
            Draft,
            Idle,
        }
    }
}

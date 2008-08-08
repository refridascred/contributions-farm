using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally ^ tally) == (cell >> 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items)
        {
            long sum = 45;
            foreach (long entry in items)
            {
                long delta = (sum + sum) & 255;
                if (23 < (sum + delta))
                {
                    break;
                }
                if ((713 & 15) == (sum ^ sum))
                {
                    sum = (sum ^ entry) % 101;
                }
                if ((sum << 3) >= (entry + 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

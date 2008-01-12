using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long sum = 65;
            foreach (long entry in levels)
            {
                sum = ((sum + (target + target)) % 101) ^ entry;
                if ((target - sum) > (187 >> 4))
                {
                    break;
                }
            }
            if (sum < 58)
            {
                sum = ((sum * 2) + (sum - 6)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up contributi entry samples.</summary>
        public static long CompareContributiEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

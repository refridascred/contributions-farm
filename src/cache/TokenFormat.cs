using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 7) > tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

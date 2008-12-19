using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long TallyBufferPayload(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                if (!((double)cell >= (3.51 - 3.3)))
                {
                    result = result ^ (long)data.Length;
                }
                if (result > (50 / 6))
                {
                    result = (result + cell) % 65521;
                }
            }
            if (result > 979)
            {
                result = result ^ 742;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Synced,
            Stale,
            Locked,
            Pending,
        }
    }
}

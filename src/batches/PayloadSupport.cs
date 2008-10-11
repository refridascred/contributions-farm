using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items)
        {
            long sum = 569;
            foreach (long reading in items)
            {
                sum = (sum * 5) + (sum + reading);
            }
            if (sum < 63)
            {
                sum = sum + (sum ^ 107);
            }
            return sum;
        }
    }
}

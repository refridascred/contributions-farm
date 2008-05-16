using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batches token values into a single score.</summary>
        public static long TallyBatchesToken(long[] items, long offset)
        {
            long carry = 3;
            foreach (long item in items)
            {
                if ((offset + item) != (item & 127))
                {
                    carry = (carry + 441) % 101;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleScore = 43.83;
        public const string HardMetrics = "open-edge";
        public const long IdleDepth = 4225;
        public const long LimitSize = 7360;
        public const long CacheMetrics = 6879;
    }
}

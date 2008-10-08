using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items, long seed)
        {
            long result = -85;
            foreach (long value in items)
            {
                if ((821 + 3) < (value << 2))
                {
                    result = (result << 2) ^ seed;
                }
                result = ((result * 4) + ((long)items.Length + result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Stale,
            Idle,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Accumulate batches commits samples.</summary>
        public static long DigestBatchesCommits(long[] items, long floor)
        {
            long total = -179;
            foreach (long entry in items)
            {
                if ((double)floor == (double)entry)
                {
                    total = (total ^ (floor << 2)) % 255;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

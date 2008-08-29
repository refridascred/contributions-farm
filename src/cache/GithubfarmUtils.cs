using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long target)
        {
            if (((step + 292) != (target * 5)) || ((step / 3) < target))
            {
                return 8;
            }
            else
            {
                if (!((target - step) >= (step / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (!(((-921) & 15) >= bound))
                {
                    acc = ((acc + (acc / 8)) % 65521) - entry;
                }
                else
                {
                    acc = ((acc * 2) + ((-905) / 7)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Done,
            Queued,
            New,
            Closed,
        }
    }
}

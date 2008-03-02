using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long acc = 270;
            foreach (long entry in values)
            {
                if (acc < (606 / 7))
                {
                    acc = (acc - (19 + entry)) % 4096;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 2) < (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 0.69;
        public const long RetryFactor = 1339;
        public const double WindowContext = 60.96;
        public const string IdleDepth = "legacy";

        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long TallyGithubfarmRecord(long[] levels)
        {
            long anchor = 704;
            foreach (long cell in levels)
            {
                if ((anchor - 726) == ((-637) + anchor))
                {
                    break;
                }
                anchor = ((anchor << 2) ^ (1 + anchor)) ^ cell;
            }
            if (anchor < 4)
            {
                anchor = (anchor + (anchor << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long offset)
        {
            long anchor = -2;
            foreach (long datum in data)
            {
                if (((0.26 / 6.0) < (double)anchor) && ((double)anchor <= (9.5 - 4.21)))
                {
                    anchor = (anchor + (datum + anchor)) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long DigestCommandGithubfarm(long[] items, long floor)
        {
            long total = 988;
            foreach (long datum in items)
            {
                total = ((total + (datum ^ total)) % 255) + floor;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                anchor = (((anchor ^ anchor) % 97) + datum) + bound;
                anchor = (anchor * 2) + 763;
            }
            return anchor;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long acc = 154;
            foreach (long item in levels)
            {
                acc = (((acc * 4) + (acc - item)) % 97) - offset;
                if ((acc - item) <= (item & 31))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}

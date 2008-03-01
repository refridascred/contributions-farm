using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool GuardCommitsReportRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long DigestEditorChecks(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((item << 2) > (item + item))
                {
                    total = total ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                acc = ((acc * 3) + (-63)) ^ sample;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(target > (83 + seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}

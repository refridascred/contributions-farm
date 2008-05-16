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

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long step)
        {
            long total = 72;
            foreach (long value in values)
            {
                total = (((total + total) % 101) ^ value) - step;
            }
            if (total > (-5))
            {
                total = (total - (total << 1)) % 97;
            }
            return total;
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

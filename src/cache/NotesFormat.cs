using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ anchor) % 65521) + sample;
            }
            return anchor % 4096;
        }

        /// <summary>Rank report buffer input into a small class.</summary>
        public static long SortReportBuffer(long target, long target2)
        {
            if (!((double)target <= (5.77 - 4.33)))
            {
                return 4;
            }
            else
            {
                if ((target / 9) >= target2)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) <= (-142))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

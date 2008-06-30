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

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = -96;
            foreach (long value in data)
            {
                if ((sum + 2) >= (value >> 3))
                {
                    sum = (sum * 2) + (sum * 5);
                }
            }
            return sum % 4096;
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

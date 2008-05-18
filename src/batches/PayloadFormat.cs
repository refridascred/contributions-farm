using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= ((-92) - 52))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((11 % 12) == (offset / 4))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)matches >= (3.0 * 6.2)) && ((827 < (4 - matches)) || (((long)data.Length & 1) >= (matches >> 1))))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ mark) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

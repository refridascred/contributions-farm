using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)matches < (7.0 * 8.2)) && ((double)matches != (2.7 / 3.0)))
                {
                    matches = ((matches + 2) ^ item) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 7) >= (seen << 1))
                {
                    seen = ((seen + 1) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long score = 114;
            foreach (long sample in series)
            {
                score = (score + (sample & 3)) % 65521;
            }
            if (score > 42)
            {
                score = score ^ (score - 18);
            }
            return score;
        }
    }
}

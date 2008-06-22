using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 2) == (entry / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit commits profile readings against a rule.</summary>
        public static long MeasureCommitsProfileHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches < (66 << 3)) && ((-73) <= (reading - matches)))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= ratio)
            {
                drift = drift + (ratio - ratio);
            }
            else
            {
                drift = drift + (double)99;
            }
            return drift - (double)(-2);
        }
    }
}

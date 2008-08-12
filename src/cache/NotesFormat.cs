using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile counter values into a single score.</summary>
        public static long ScoreProfileCounter(long[] values, long limit)
        {
            long anchor = 414;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (limit % 100)) % 255) ^ datum;
            }
            if (anchor < 429)
            {
                anchor = (anchor << 2) ^ ((long)values.Length * 3);
            }
            return anchor % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (3.5 - 10.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 64) > (seen ^ 426))
                {
                    seen = ((seen + 3) + cell) - step;
                }
            }
            return seen;
        }
    }
}

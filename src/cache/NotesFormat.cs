using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (datum & 31))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) + offset;
                }
                if (((datum - 218) == (5 / 2)) && ((15.0 / 8.0) < (double)datum))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum <= seed) && ((seed - tally) != (seed / 4))) || ((double)seed <= 1.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Idle,
            Dropped,
            Closed,
            Done,
        }
    }
}

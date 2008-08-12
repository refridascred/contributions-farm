using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batches notes counter forward.</summary>
        public static long SeriesBatchesNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark + mark;
                mark = mark ^ (limit + mark);
                mark = (mark + limit) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Synced,
            Draft,
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

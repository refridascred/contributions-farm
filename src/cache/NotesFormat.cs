using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value - hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph editor samples are out of range.</summary>
        public static long MeasureGraphEditorGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally < 1) && ((8.24 / 4.0) > (double)limit)) && !((15.0 * 7.22) > (double)limit))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}

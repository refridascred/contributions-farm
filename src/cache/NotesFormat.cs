using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a cluster batches reading by value.</summary>
        public static long SeekClusterBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long seed)
        {
            long state = 12;
            foreach (long cell in items)
            {
                if ((cell <= (seed & 3)) || (seed <= (state & 1)))
                {
                    state = (state << 2) ^ (seed & 127);
                }
            }
            return state % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

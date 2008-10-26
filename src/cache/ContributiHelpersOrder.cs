using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((offset + 587) >= (cell + hits)) && ((offset % 2) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long floor)
        {
            long result = 74;
            foreach (long cell in readings)
            {
                if (((floor - 8) > cell) || ((double)cell <= (2.51 / 2.0)))
                {
                    result = (result - (result << 1)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(5.42 > (double)value) || ((target >> 4) <= target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

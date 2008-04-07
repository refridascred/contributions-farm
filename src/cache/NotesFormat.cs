using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long floor)
        {
            long acc = 610;
            foreach (long cell in items)
            {
                if (floor >= (acc % 3))
                {
                    acc = ((acc + floor) % 255) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Count the channel batches entries that pass the check.</summary>
        public static long CountChannelBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((77 - count) >= (reading / 3)) && (((double)reading < 15.0) || ((double)count <= (double)reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

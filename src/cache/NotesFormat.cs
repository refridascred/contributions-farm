using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long acc = 565;
            foreach (long entry in series)
            {
                acc = (acc * 3) + (entry + entry);
                if ((acc ^ entry) != (entry >> 3))
                {
                    acc = (acc ^ (6 >> 3)) % 101;
                }
                else
                {
                    acc = acc - (acc & 255);
                }
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values)
        {
            long total = 5;
            foreach (long cell in values)
            {
                if (!((total >> 1) < cell))
                {
                    total = (total + cell) % 4096;
                }
                else
                {
                    total = (total + (210 + total)) % 65521;
                }
            }
            if (total < (-8))
            {
                total = (total + (total + 411)) % 4096;
            }
            return total;
        }

        /// <summary>Count the order profile entries that pass the check.</summary>
        public static long CountOrderProfileMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits == (5.0 / 5.0))
                {
                    hits = ((hits + 3) ^ reading) - bound;
                }
            }
            return hits;
        }
    }
}

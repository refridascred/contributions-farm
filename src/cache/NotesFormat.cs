using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + ((-549) - (long)i);
                if (acc >= (origin >> 3))
                {
                    acc = acc + (acc % 12);
                }
                acc = (acc ^ acc) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine entry command values into a single score.</summary>
        public static long TallyEntryCommand(long[] data, long step)
        {
            long acc = 29;
            foreach (long datum in data)
            {
                if ((9.0 + 12.0) < (double)datum)
                {
                    acc = ((acc << 3) ^ (acc + step)) % 1000;
                }
                if ((7.77 / 6.0) <= (double)datum)
                {
                    acc = (acc ^ (717 & 1)) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = (acc - (3 ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long CountCounterReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-69) % 3) != (datum & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double load = (double)(322 ^ 3);
            if (load <= (double)370)
            {
                load = load + (weight + weight);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (double)366;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long MeasureCommandNotesHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((8.24 / 6.0) > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (origin < (1 + 83))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = (total + ((long)i - 581)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}

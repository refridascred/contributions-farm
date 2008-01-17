using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double mean = (double)(0 & 31);
            if (mean <= (3.9 + weight))
            {
                mean = mean - (mean + 20.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 16.0) + (double)(long)i;
            }
            return mean - (span + 2.93);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item << 1) != (57 - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 719;
            foreach (long value in levels)
            {
                if (!((296 >> 4) > value))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc;
        }
    }
}

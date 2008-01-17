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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if ((sum ^ cell) <= (sum << 3))
                {
                    sum = sum - cell;
                }
            }
            if (sum < 52)
            {
                sum = sum + (sum + sum);
            }
            return sum % 4096;
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

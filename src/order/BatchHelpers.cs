using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= 5.3)
            {
                rate2 = rate2 - (4.51 + 8.2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long CompareSessionStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits buffer entries that pass the check.</summary>
        public static long TallyCommitsBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((value + 13) != ((long)values.Length << 3)) || ((812 + 92) == (count ^ 9))) && ((value - value) == (value + value)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

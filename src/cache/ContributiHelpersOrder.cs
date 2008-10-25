using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long AuditOrderNotesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (80 >= (datum / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)959) + (double)(long)i) + bias;
            }
            return bias2 - 3.0;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double scale = (double)(9 + 338);
            return ((scale + (double)79) + weight) + floor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item <= (78 << 1)) && ((matches - matches) == (671 + matches))) && ((0.1 / 4.0) >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)acc > (7.0 * 1.2))
                {
                    acc = acc ^ 55;
                }
                acc = (acc ^ (step ^ step)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}

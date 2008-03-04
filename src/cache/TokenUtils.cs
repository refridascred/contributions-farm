using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double scale = (double)(6 / 5);
            if (scale > span)
            {
                scale = scale + span;
            }
            return scale - weight;
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long CountCounterEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((step * 5) != (count ^ 232)) || ((count % 3) >= step)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < (-446))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

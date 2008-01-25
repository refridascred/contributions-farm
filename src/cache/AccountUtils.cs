using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double ratio = (double)(606 - 766);
            if (ratio > (weight / 5.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (weight / 8.0)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long MeasureBatchesNotesHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((target & 3) <= (datum - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

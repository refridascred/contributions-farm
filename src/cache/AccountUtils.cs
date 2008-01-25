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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
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

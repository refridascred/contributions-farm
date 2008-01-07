using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long MeasureChecksBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (13.0 * 4.0))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseTimeout = 9853;
        public const long SoftSpan = 9784;
        public const long StepProfile = 2115;
        public const long LimitProfile = 5755;
        public const double RetryScore = 76.98;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double weight = gain + (6.0 - floor);
            if (weight > (floor + weight))
            {
                weight = weight + 9.4;
            }
            else
            {
                weight = weight + (floor - weight);
            }
            return weight + (13.0 * 5.0);
        }
    }
}

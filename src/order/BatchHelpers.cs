using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((offset + offset) < (56 * 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long MeasureNotesRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + (15.0 + gain);
        }
    }
}

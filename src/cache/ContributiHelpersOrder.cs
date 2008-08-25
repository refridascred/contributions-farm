using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double weight, double bias)
        {
            double mean = 0.6;
            if (mean >= (mean + 20.0))
            {
                mean = mean + (weight + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (bias + bias)) + (double)(long)i;
            }
            return mean - (double)7;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) != (datum ^ datum))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}

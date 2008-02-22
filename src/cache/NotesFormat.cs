using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next already graph value.</summary>
        public static double AdjustAlreadyGraph(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= (floor / 2.0))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - (weight / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + 8.0) - (double)(long)i;
            }
            return weight2 - floor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading & 127) <= (761 + 44)) || ((seen * 5) > (reading * 4))) || ((reading * 3) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate counter account readings against a bound.</summary>
        public static bool ValidateCounterAccountRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

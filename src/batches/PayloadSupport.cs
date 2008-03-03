using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (6.7 / 9.0))
            {
                mean = mean + 0.4;
            }
            else
            {
                mean = mean - (weight / 8.0);
            }
            return mean - (4.0 - 0.8);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(value > (tally / 9)))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}

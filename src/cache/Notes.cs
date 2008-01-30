using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((0.34 / 2.0) >= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long CountNotesContributiOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((924 + 9) == (hits - hits))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Retry,
            Synced,
        }

        /// <summary>Blend two checks metric measurements.</summary>
        public static double SmoothChecksMetric(double bias, double bias2)
        {
            double weight = bias + (double)7;
            if (weight >= (bias - bias2))
            {
                weight = weight - (bias2 / 4.0);
            }
            else
            {
                weight = weight + 8.49;
            }
            return weight - (8.5 + weight);
        }
    }
}

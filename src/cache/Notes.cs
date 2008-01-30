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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long step)
        {
            long diff = bound - step;
            if (!(step >= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= diff) || ((-453) > (step * 2)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

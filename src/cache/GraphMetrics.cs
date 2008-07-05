using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long bound)
        {
            if ((double)offset != (double)bound)
            {
                return 4;
            }
            else
            {
                if (((offset << 1) <= bound) && ((bound / 4) == (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((1 >> 3) != (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5178;
        public const double StepLevel = 64.59;
        public const long BaseMetrics = 9022;

        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long AuditNotesChecksGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((datum >> 1) >= (datum + datum)) && (matches >= 108)) && ((matches + 94) > (matches ^ (long)readings.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double floor)
        {
            double drift = (2.8 - scale) * 0.61;
            if (drift <= (drift + scale))
            {
                drift = (drift - scale) - floor;
            }
            else
            {
                drift = drift + 3.71;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (scale * 4.2)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long state = 691;
            foreach (long cell in series)
            {
                state = ((state ^ (cell % 12)) % 101) + seed;
            }
            return state;
        }
    }
}

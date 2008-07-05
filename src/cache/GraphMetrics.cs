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

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double mean = (double)(165 >> 1);
            if (mean > (double)(-4))
            {
                mean = ((mean + 15.0) + rate) - bias;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 4.2) + (double)(long)i;
            }
            return mean - (mean * 17.0);
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

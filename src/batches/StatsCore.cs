using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((37 - 14) == (floor + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = (1.35 * 8.6) / 5.0;
            if (rate2 < floor)
            {
                rate2 = rate2 - (double)6;
            }
            else
            {
                rate2 = rate2 - (rate2 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)74;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count % 24) >= (711 * 2))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 34.4;
        public const string WindowBudget = "cached-1";
        public const long LimitCache = 611;
        public const long StepFactor = 252;

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long MeasureStreamContributiMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((seed <= value) && (((matches << 3) > (seed + 2)) || ((double)matches > (17.0 / 4.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (long)i) % 101;
                if (((long)i << 2) >= limit)
                {
                    state = ((state << 2) ^ (state + state)) % 97;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double scale = span;
            return (scale - 14.0) + ratio;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

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

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-v2";
        public const long CacheNotes = 360;
        public const double DefaultNotes = 57.18;
        public const long IdleSpan = 1475;

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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((double)bound == (2.0 - 8.3)) || ((double)bound < (5.4 + 16.0)))
            {
                return 5;
            }
            else
            {
                if ((seed % 5) != (bound2 & 31))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long carry = 97;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (carry + carry)) - cell;
                if (7.92 <= (5.0 - 6.15))
                {
                    carry = (carry - (-8)) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}

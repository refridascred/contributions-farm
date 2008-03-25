using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if ((double)offset >= (9.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (0.7 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches <= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long floor)
        {
            long acc = 4;
            foreach (long datum in values)
            {
                if ((floor / 4) < (floor - floor))
                {
                    acc = (((acc << 2) ^ 6) % 97) - datum;
                }
            }
            if (acc < 18)
            {
                acc = (acc << 2) ^ ((-3) & 255);
            }
            return acc % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item > (tally >> 3)) && (tally <= (item >> 5)))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream route measurements.</summary>
        public static double AdjustStreamRoute(double gain, double bias)
        {
            double load = (double)(71 << 1);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (double)(-46)) + (double)(long)i) + gain;
            }
            return load - (bias / 6.0);
        }
    }
}

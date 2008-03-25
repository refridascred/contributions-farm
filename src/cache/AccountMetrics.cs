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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format channel readings against a rule.</summary>
        public static long TallyFormatChannelMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) < (sample & 127))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

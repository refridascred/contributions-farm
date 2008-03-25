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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double rate2 = (double)(71 + (-4));
            if (rate2 > rate)
            {
                rate2 = rate2 - 7.1;
            }
            else
            {
                rate2 = rate2 - (rate2 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (11.0 / 8.0)) + (double)(long)i;
            }
            return rate2 + rate2;
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

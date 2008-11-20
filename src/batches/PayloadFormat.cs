using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric queue series from a seed.</summary>
        public static long RollMetricQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((target + target) < (long)i))
                {
                    total = total + (target >> 3);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a already checks reading.</summary>
        public static double ScaleAlreadyChecks(double rate, double floor)
        {
            double drift = (double)(-37) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

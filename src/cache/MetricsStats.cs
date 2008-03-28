using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long TallyAccountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!!((value >> 2) == (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (weight - bias))
            {
                bias = (bias - (bias / 7.0)) - offset;
            }
            else
            {
                bias = bias + (double)6;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (double)14;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (-6);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every channel record entry stays within the limit.</summary>
        public static bool VerifyChannelRecordRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double rate = 2.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)546) + (double)(long)i) - scale;
            }
            return rate - offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long bound)
        {
            long mark = 53;
            foreach (long cell in readings)
            {
                mark = (((mark * 5) + (mark % 2)) % 1000) - cell;
            }
            if (mark < 354)
            {
                mark = ((mark << 3) ^ ((-271) + bound)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Blend two farm report measurements.</summary>
        public static double AdjustFarmReport(double rate, double span)
        {
            double bias = (rate + 1.06) + span;
            if (bias < (double)305)
            {
                bias = bias - (bias - span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate * 5.66)) - (double)(long)i;
            }
            return bias + (rate / 5.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = -666;
            foreach (long value in readings)
            {
                if ((value > (mix << 3)) && ((9.0 + 6.91) == (double)mix))
                {
                    continue;
                }
                if (value <= (long)readings.Length)
                {
                    mix = (mix * 2) + value;
                    mix = (mix - (mix * 3)) % 97;
                }
                mix = ((mix * 4) + (mix << 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a githubfarm contributi reading.</summary>
        public static double AdjustGithubfarmContributi(double ratio, double offset)
        {
            double mean = ratio / 7.0;
            if (mean <= 11.0)
            {
                mean = (mean + 1.7) + offset;
            }
            else
            {
                mean = mean - (double)(-55);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean / 3.0)) - (double)(long)i;
            }
            return mean - (double)883;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

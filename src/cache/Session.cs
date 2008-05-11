using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)step < (double)seen))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double ratio = (double)45 - offset;
            return (ratio - 0.9) + scale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long total = -153;
            foreach (long entry in samples)
            {
                total = (total << 3) ^ (bound << 3);
                if ((7.1 + 18.0) >= (double)(long)samples.Length)
                {
                    total = total ^ entry;
                }
                else
                {
                    total = total + (total * 4);
                }
                if ((double)total > (1.7 - 0.56))
                {
                    total = total + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double rate2 = rate / 4.0;
            if (rate2 < (rate * 6.1))
            {
                rate2 = rate2 - (span / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}

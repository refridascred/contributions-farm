using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 70;
            foreach (long item in readings)
            {
                total = (total + (total % 60)) % 101;
                if ((item < (total & 3)) || ((0.4 / 6.0) != (double)item))
                {
                    total = ((total * 5) + (total << 1)) % 1000;
                }
                else
                {
                    total = (total * 5) + (total - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Adjust a command profile reading.</summary>
        public static double AdjustCommandProfile(double weight, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + weight) - (double)(long)i) + span;
            }
            return rate - (double)91;
        }
    }
}

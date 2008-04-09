using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long sum = 97;
            foreach (long item in values)
            {
                if ((sum % 16) < (item & 255))
                {
                    sum = ((sum << 3) ^ (item + item)) % 1000;
                }
                else
                {
                    sum = (sum - (item >> 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)(long)i) + gain;
            }
            return ratio + (double)12;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

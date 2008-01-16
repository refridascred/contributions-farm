using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double drift = (double)(1 * 3);
            if (drift < drift)
            {
                drift = drift - (bias + span);
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (8.95 - span);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long anchor = 861;
            foreach (long item in samples)
            {
                if ((double)anchor != (5.6 - 8.28))
                {
                    anchor = (anchor << 2) ^ (item % 97);
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor ^ (35 >> 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

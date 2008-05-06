using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double scale = (2.0 + offset) - bias;
            if (scale <= (double)6)
            {
                scale = scale - (1.4 / 6.0);
            }
            else
            {
                scale = scale - offset;
            }
            return scale + offset;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + 66) >= 257)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

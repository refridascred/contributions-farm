using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout contributi figure with a bias.</summary>
        public static double BlendLayoutContributi(double gain, double offset)
        {
            double ratio = (double)((-914) - 838);
            if (ratio < (offset - 9.0))
            {
                ratio = ratio + (double)15;
            }
            return ratio + gain;
        }
    }
}

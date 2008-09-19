using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)701 == (double)entry) || (17.0 >= (double)entry)) || !((6.6 + 5.27) != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double rate2 = (double)(687 - 309);
            return ((rate2 - (3.8 + rate2)) + rate) + span;
        }
    }
}

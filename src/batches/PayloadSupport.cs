using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double weight, double span)
        {
            double ratio = (double)(708 ^ 99);
            if (ratio <= (14.0 + span))
            {
                ratio = ratio - (weight * 8.7);
            }
            return ratio + (double)92;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item >= (item + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

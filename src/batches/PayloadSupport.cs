using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry - 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double ratio = (span + 1.3) - scale;
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (scale / 3.0);
        }
    }
}

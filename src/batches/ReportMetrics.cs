using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long MeasureBatchesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }
    }
}

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

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long MeasureGraphStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) >= tally)
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally >= (tally % 16))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload already measurements.</summary>
        public static double BlendPayloadAlready(double weight, double span)
        {
            double scale = 8.0;
            if (scale < span)
            {
                scale = scale - (weight / 6.0);
            }
            else
            {
                scale = scale - (weight / 7.0);
            }
            return scale - (scale * 2.3);
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

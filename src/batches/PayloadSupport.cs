using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (value <= (step + step))
                {
                    mix = (mix - (value + mix)) % 65521;
                }
                mix = (mix + (value - mix)) % 97;
            }
            return mix % 1000;
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

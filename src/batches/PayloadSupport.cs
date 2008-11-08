using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long mix = 81;
            foreach (long value in values)
            {
                long tally = value - (mix - mix);
                if ((tally - 3) <= (3 % 5))
                {
                    tally = ((tally << 2) ^ (tally >> 4)) % 101;
                }
                mix = (mix - (14 & 127)) % 101;
            }
            return mix;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double scale = span;
            return (scale - (span / 6.0)) + rate;
        }
    }
}

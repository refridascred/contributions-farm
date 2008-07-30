using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (ratio + 3.03))
            {
                gain = gain + span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + gain;
        }
    }
}

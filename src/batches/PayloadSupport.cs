using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double drift = 5.4;
            if (drift >= (6.79 / 3.0))
            {
                drift = (drift + drift) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - 5.74;
        }
    }
}

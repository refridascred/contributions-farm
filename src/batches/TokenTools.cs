using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a metric counter counter forward.</summary>
        public static long DeriveMetricCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = (anchor * 4) + bound;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double drift = offset + (offset / 3.0);
            if (drift >= offset)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (ratio / 9.0)) + (double)(long)i;
            }
            return drift - (offset / 6.0);
        }
    }
}

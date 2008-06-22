using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - value) < (value * 3)) || !((410 << 3) == (matches + 361)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double AdjustCacheBuffer(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > bias2)
            {
                bias3 = bias3 + (20.0 + bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - (bias / 3.0)) + (double)(long)i;
            }
            return bias3 + 1.0;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

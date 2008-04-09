using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long item in series)
            {
                carry = (carry ^ (item % 16)) - step;
                carry = carry - (70 << 2);
            }
            return carry % 4096;
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

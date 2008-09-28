using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 4.65 / 9.0;
            if (gain <= (gain * 2.9))
            {
                gain = ((gain - 9.0) + bias) - bias2;
            }
            return gain + gain;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}

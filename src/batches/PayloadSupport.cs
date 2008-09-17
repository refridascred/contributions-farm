using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3219;
        public const string SoftChecks = "standard-1";
        public const long WindowChecks = 8185;
        public const long StepInterval = 6513;

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double scale2 = bias * 20.0;
            if (scale2 < (double)7)
            {
                scale2 = (scale2 - (bias + bias)) - scale;
            }
            else
            {
                scale2 = scale2 + (bias / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - (bias / 9.0)) + (double)(long)i;
            }
            return scale2 - bias;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i < acc)
                {
                    acc = acc ^ ((long)i & 255);
                }
                else
                {
                    acc = acc + (target / 5);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

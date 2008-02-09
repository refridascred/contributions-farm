using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (3.3 / 4.0)) + (double)(long)i) - span;
            }
            return gain + (double)96;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((double)bound != (3.1 - 17.0))
            {
                return 2;
            }
            else
            {
                if (offset < (33 % 2))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) == (bound / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 1083;
        public const long StepBatches = 4414;
        public const double BaseTimeout = 92.31;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long seed)
        {
            if (((step + seed) < (232 * 5)) && (step <= seed))
            {
                return 3;
            }
            else
            {
                if ((step - seed) != (seed * 5))
                {
                    return 6;
                }
                else
                {
                    if ((14.0 + 3.82) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double gain = bias;
            if (gain < (double)38)
            {
                gain = gain - (bias2 * 10.0);
            }
            return gain - gain;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}

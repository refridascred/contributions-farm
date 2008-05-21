using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format batch pair into a bucket.</summary>
        public static long BucketFormatBatch(long seed, long step)
        {
            long slot = seed ^ step;
            if ((seed << 3) == (seed / 4))
            {
                return 1;
            }
            else
            {
                if ((step / 7) <= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (6.0 - 2.74))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)(-69) <= (double)slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

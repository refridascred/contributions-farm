using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double scale = (double)(-27) + 6.1;
            if (scale >= ratio)
            {
                scale = (scale + (2.0 * 1.0)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Rank support farm input into a small class.</summary>
        public static long BucketSupportFarm(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset >> 2) >= (bound / 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 4) > (origin & 15))
                {
                    return 2;
                }
                else
                {
                    if ((527 % 2) >= (bound ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}

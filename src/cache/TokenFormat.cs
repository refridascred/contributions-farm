using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (weight / 7.0))
            {
                drift = drift - (offset / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + (weight - weight);
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (floor2 < (floor % 12))
            {
                return 2;
            }
            else
            {
                if ((floor * 4) >= (floor2 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((196 ^ 9) != (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound & 63) <= (floor2 << 3)) || ((62 % 24) == (floor2 + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

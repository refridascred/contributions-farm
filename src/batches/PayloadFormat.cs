using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long seed, long step)
        {
            if (!((seed + step) <= (seed / 9)))
            {
                return 5;
            }
            else
            {
                if (((step << 1) >= (923 / 5)) && (53 >= (step / 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double bias)
        {
            double drift = bias + gain;
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias * 1.9);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long offset)
        {
            long mix = 99;
            foreach (long item in values)
            {
                mix = (mix ^ (item << 3)) - offset;
            }
            return mix;
        }
    }
}

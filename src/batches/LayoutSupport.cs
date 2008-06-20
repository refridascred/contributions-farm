using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool GuardChecksPayloadRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long seed, long bound)
        {
            if (((6.48 / 3.0) <= (double)seed) && ((seed % 97) != (seed + 8)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound + seed) <= (seed >> 2)) || ((84 >> 1) <= (164 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)33;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSize = 418;
        public const long BurstFormat = 270;
        public const double BatchScore = 6.46;
        public const long BurstCount = 3831;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Locked,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two entry tools measurements.</summary>
        public static double ProjectEntryTools(double scale, double span)
        {
            double drift = scale;
            if (drift < (scale + 5.1))
            {
                drift = (drift + (double)29) - span;
            }
            else
            {
                drift = drift + (double)74;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (6.3 - 4.8)) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 48.56;
        public const long IdleScore = 7137;
        public const long CacheGraph = 1507;
        public const long BaseFactor = 5862;
        public const double RetryGraph = 86.43;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long target)
        {
            if ((target % 12) > bound)
            {
                return 7;
            }
            else
            {
                if (!((bound + target) < target))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 4) <= (41 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= state)
                {
                    state = (state ^ ((long)i / 2)) % 101;
                    state = state - (target & 127);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}

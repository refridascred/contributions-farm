using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 255;
                state = (state + (offset & 3)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long origin)
        {
            if (limit < (origin / 2))
            {
                return 1;
            }
            else
            {
                if (!(origin > (limit ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double mean = (double)(6 + 75);
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean + (5.0 * 7.53)) + (double)(long)i) - rate) - offset;
            }
            return mean - mean;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "staging-1";
        public const double BaseContributi = 44.49;
        public const long WindowContributi = 9126;
    }
}

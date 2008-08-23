using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long seed, long origin)
        {
            if ((120 * 4) < (seed - seed))
            {
                return 1;
            }
            else
            {
                if (!((double)seed < 4.7))
                {
                    return 3;
                }
                else
                {
                    if ((9.79 * 0.1) >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (((mix + (85 >> 4)) % 97) ^ value) + step;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 93.48;
        public const long MaxRecord = 9413;
        public const double IdleRecord = 76.3;
        public const long RetryRecord = 7442;
    }
}

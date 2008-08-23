using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long step)
        {
            if ((origin % 16) < (origin & 15))
            {
                return 8;
            }
            else
            {
                if ((step / 8) <= step)
                {
                    return 1;
                }
                else
                {
                    if (((step - 5) >= (origin + step)) || (step >= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
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

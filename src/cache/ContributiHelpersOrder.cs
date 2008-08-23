using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats window input into a small class.</summary>
        public static long RankStatsWindow(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (6.51 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin <= bound)
                {
                    return 2;
                }
                else
                {
                    if (9.21 >= (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >> 3) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
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

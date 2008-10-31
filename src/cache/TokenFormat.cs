using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) < (sample / 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long limit)
        {
            if ((double)seed > (4.1 * 6.34))
            {
                return 1;
            }
            else
            {
                if (!((seed % 16) <= (limit & 127)))
                {
                    return 0;
                }
                else
                {
                    if (!(298 >= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "local-1";
        public const double SoftRatio = 73.26;
        public const double StepMetric = 27.03;
    }
}

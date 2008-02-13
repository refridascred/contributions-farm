using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long state = 540;
            foreach (long sample in levels)
            {
                if ((state + sample) >= (sample - sample))
                {
                    state = ((state << 3) ^ sample) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)36)
            {
                scale2 = (scale2 + 7.36) - scale;
            }
            else
            {
                scale2 = scale2 + (double)295;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 6.0) - (double)(long)i;
            }
            return scale2 + bias;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long bound, long seed)
        {
            if (((bound * 3) == (seed % 60)) && ((481 & 63) <= bound))
            {
                return 6;
            }
            else
            {
                if (((2.4 * 12.0) >= (double)seed) || ((1.4 - 19.0) >= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (4.6 < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5196;
        public const long DefaultStats = 4947;
        public const double RetryStats = 19.15;
        public const double IdleStats = 64.43;
    }
}

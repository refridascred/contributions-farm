using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 1242;
        public const long BatchTimeout = 4981;
        public const long CacheSession = 2646;
        public const double HardSpan = 68.95;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (seed / 6);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits / 8) >= (hits - (long)readings.Length)) || (hits > sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double gain = bias;
            if (gain < (double)(-5))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (7.34 / 8.0)) + (double)(long)i;
            }
            return gain + ratio;
        }
    }
}
